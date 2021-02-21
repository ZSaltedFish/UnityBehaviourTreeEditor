using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model
{
	[DataContract]
	public class NodeProto
	{
		[DataMember]
		public int Id;

		[DataMember]
		public string Name;

		[DataMember]
		public string Desc = "";

		[DataMember]
		public BehaviorTreeArgsDict Args;

		[DataMember]
		public List<NodeProto> children = new List<NodeProto>();

		public List<NodeProto> Children
		{
			get
			{
				return this.children;
			}
			set
			{
				this.children = value;
			}
		}

		public NodeProto()
		{
			this.Args = new BehaviorTreeArgsDict();
		}

		public NodeProto(BehaviorTreeArgsDict dict)
		{
			this.Args = dict;
		}
	}
}