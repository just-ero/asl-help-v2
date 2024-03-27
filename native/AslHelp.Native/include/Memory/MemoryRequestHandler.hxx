#pragma once

#include <cstdint>
#include <stdint.h>
#include <vector>

#include "IO/Logging/Loggers.hxx"
#include "IO/Logging/LoggingService.hxx"
#include "IO/NamedPipeServer.hxx"
#include "IO/PipeRequest.hxx"
#include "IO/PipeResponse.hxx"


namespace Memory
{

class MemoryRequestHandler
{
private:
    const IO::NamedPipeServer& _pipeServer;
    const std::unique_ptr<IO::Logging::ConsoleLogger> _logger
#ifdef _DEBUG
        = IO::Logging::LoggingService::Create<IO::Logging::ConsoleLogger>();
#else
        = nullptr;
#endif

public:
    MemoryRequestHandler(const IO::NamedPipeServer& pipeServer)
        : _pipeServer(pipeServer)
    {
    }

    void HandleNextRequest(const IO::PipeRequest& cmd) const
    {
        switch (cmd)
        {
        case IO::PipeRequest::Deref: {
            HandleDerefRequest();
            break;
        }
        case IO::PipeRequest::Read: {
            HandleReadRequest();
            break;
        }
        case IO::PipeRequest::Write: {
            HandleWriteRequest();
            break;
        }
        case IO::PipeRequest::Close:
        default: {
            _pipeServer.TryWrite(IO::PipeResponse::UnknownCommand);
            break;
        }
        }
    }

private:
    void HandleDerefRequest() const
    {
        DEBUG_LOG(_logger, "  => Dereferencing offsets...");

        auto address = _pipeServer.TryRead<uint64_t>();
        if (!address.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto offsetsLength = _pipeServer.TryRead<uint32_t>();
        if (!offsetsLength.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto offsets = _pipeServer.TryRead<int32_t>(offsetsLength.value());
        if (!offsets.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto deref = DereferencePath(address.value(), offsets.value());
        if (deref == 0)
        {
            DEBUG_LOG(_logger, "    => Failure. Cannot dereference null pointer.");
            _pipeServer.TryWrite(IO::PipeResponse::DerefFailure);

            return;
        }

        DEBUG_LOG(_logger, "    => Success.");
        DEBUG_LOG(_logger, "       Result: 0x{:X}.", deref);

        _pipeServer.TryWrite(IO::PipeResponse::Success);
        _pipeServer.TryWrite((uint64_t)deref);
    }

    void HandleReadRequest() const
    {
        DEBUG_LOG(_logger, "  => Dereferencing offsets...");

        auto address = _pipeServer.TryRead<uint64_t>();
        if (!address.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto offsetsLength = _pipeServer.TryRead<uint32_t>();
        if (!offsetsLength.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto offsets = _pipeServer.TryRead<int32_t>(offsetsLength.value());
        if (!offsets.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto deref = DereferencePath(address.value(), offsets.value());
        if (deref == 0)
        {
            DEBUG_LOG(_logger, "    => Failure. Cannot dereference null pointer.");
            _pipeServer.TryWrite(IO::PipeResponse::DerefFailure);

            return;
        }

        DEBUG_LOG(_logger, "    => Success.");
        DEBUG_LOG(_logger, "       Result: 0x{:X}.", deref);

        DEBUG_LOG(_logger, "  => Reading data...");

        auto bytes = _pipeServer.TryRead<uint32_t>();
        if (!bytes.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        std::vector<uint8_t> buffer(bytes.value());

        if (TryCpy((void*)deref, buffer.data(), bytes.value()))
        {
            DEBUG_LOG(_logger, "    => Success.");

            _pipeServer.TryWrite(IO::PipeResponse::Success);
            _pipeServer.TryWrite(buffer);
        }
        else
        {
            DEBUG_LOG(_logger, "    => Failure. Cannot dereference result address.");

            _pipeServer.TryWrite(IO::PipeResponse::ReadFailure);
        }
    }

    void HandleWriteRequest() const
    {
        DEBUG_LOG(_logger, "  => Dereferencing offsets...");

        auto address = _pipeServer.TryRead<uint64_t>();
        if (!address.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto offsetsLength = _pipeServer.TryRead<uint32_t>();
        if (!offsetsLength.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto offsets = _pipeServer.TryRead<int32_t>(offsetsLength.value());
        if (!offsets.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto deref = DereferencePath(address.value(), offsets.value());
        if (deref == 0)
        {
            DEBUG_LOG(_logger, "    => Failure. Cannot dereference null pointer.");
            _pipeServer.TryWrite(IO::PipeResponse::DerefFailure);

            return;
        }

        DEBUG_LOG(_logger, "    => Success.");
        DEBUG_LOG(_logger, "       Result: 0x{:X}.", deref);

        DEBUG_LOG(_logger, "  => Writing data...");

        auto dataLength = _pipeServer.TryRead<uint32_t>();
        if (!dataLength.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        auto data = _pipeServer.TryRead<uint8_t>(dataLength.value());
        if (!data.has_value())
        {
            HandleReceiveFailure();
            return;
        }

        if (TryCpy((void*)deref, data->data(), dataLength.value()))
        {
            DEBUG_LOG(_logger, "    => Success.");

            _pipeServer.TryWrite(IO::PipeResponse::Success);
        }
        else
        {
            DEBUG_LOG(_logger, "    => Failure. Cannot dereference result address.");

            _pipeServer.TryWrite(IO::PipeResponse::WriteFailure);
        }
    }

    void HandleReceiveFailure() const
    {
        DEBUG_LOG(_logger, "    => Failure. Cannot read request.");
        _pipeServer.TryWrite(IO::PipeResponse::ReceiveFailure);
    }

    static bool TryCpy(const void* src, void* dst, size_t size)
    {
        __try
        {
            memcpy(dst, src, size);
            return true;
        }
        __except (EXCEPTION_EXECUTE_HANDLER)
        {
            return false;
        }
    }

    static intptr_t DereferencePath(uint64_t baseAddress, const std::vector<int32_t> offsets)
    {
        auto deref = (intptr_t)baseAddress;

        __try
        {
            for (const auto offset : offsets)
            {
                deref = *(intptr_t*)deref;
                if (deref == 0)
                {
                    return 0;
                }

                deref += offset;
            }
        }
        __except (EXCEPTION_EXECUTE_HANDLER)
        {
            return 0;
        }

        return (intptr_t)deref;
    }
};

} // namespace Memory
