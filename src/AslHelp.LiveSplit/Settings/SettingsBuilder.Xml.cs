using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AslHelp.LiveSplit.Settings;

public partial class SettingsBuilder
{
    [XmlType("Setting")]
    private sealed class XmlSetting
    {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
        [XmlAttribute] public required string Id;
        [XmlAttribute] public required string Label;
        [XmlAttribute] public required string? State;
        [XmlAttribute] public required string? ToolTip;

        [XmlElement("Setting")] public required XmlSetting[]? Children;
#pragma warning restore CS0649
    }

    public void FromXml(string path)
    {
        using FileStream fs = File.OpenRead(path);
        XmlSerializer ser = new(typeof(XmlSetting[]), new XmlRootAttribute("Settings"));
        if (ser.Deserialize(fs) is not XmlSetting[] settings)
        {
            const string Msg = "Xml settings file was in an incorrect format.";
            throw new FormatException(Msg);
        }

        IEnumerable<Setting> converted = ConvertFromXml(settings);
        Add(converted);
    }

    private IEnumerable<Setting> ConvertFromXml(XmlSetting[] nodes, string? parent = null)
    {
        for (int i = 0; i < nodes.Length; i++)
        {
            XmlSetting node = nodes[i];
            yield return new(
                node.Id,
                bool.TryParse(node.State, out bool state) ? state : false,
                node.Label,
                parent,
                node.ToolTip);

            if (node.Children is { Length: > 0 } children)
            {
                foreach (Setting setting in ConvertFromXml(children, node.Id))
                {
                    yield return setting;
                }
            }
        }
    }
}
