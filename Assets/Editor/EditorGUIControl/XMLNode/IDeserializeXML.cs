﻿using System.Xml;

namespace Model
{
    public interface IDeserializeXML
    {
        object Deserialize(XmlAttribute data, IEditorControl ctrl);
    }
}