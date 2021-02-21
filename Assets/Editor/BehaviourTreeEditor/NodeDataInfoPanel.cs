using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class NodeDataInfoPanel : EditorControl
    {
        private const string NONE_SELECTED = "No output was selected.";

        private NodeParam _node;
        private NodeParamIOData _infos;

        private Dictionary<Type, List<ParamInfoOutput>> _outputs = new Dictionary<Type, List<ParamInfoOutput>>();
        private Dictionary<ParamInfoInput, int> _typeIndexSelection = new Dictionary<ParamInfoInput, int>();
        private Dictionary<ParamInfoInput, string[]> _typeIndexShow = new Dictionary<ParamInfoInput, string[]>();

        public Action OnDataChange;
        public Action OnOutputNameChange;

        public NodeDataInfoPanel()
        {
            Active = false;
            OnMouseClick.Add(UseEvent);
            OnRightClick.Add(UseEvent);
            OnMouseDown.Add(UseEvent);
        }

        private void UseEvent(EditorControl ec, EditorEvent ee)
        {
            ee.Use();
        }

        public void Show(NodeParam node, NodeParamIOData infos)
        {
            GUI.FocusControl("强制测试用名");
            Active = true;
            _node = node;
            _infos = infos;

            _outputs.Clear();
            _typeIndexSelection.Clear();
            _typeIndexShow.Clear();

            foreach (ParamInfoInput pair in _node.Inputs)
            {
                List<ParamInfoOutput> outputs;
                if (!_outputs.TryGetValue(pair.InputType, out outputs))
                {
                    outputs = _infos[pair.InputType];
                    _outputs.Add(pair.InputType, outputs);
                }

                List<string> shows = new List<string>();
                foreach (ParamInfoOutput output in outputs)
                {
                    shows.Add($"{output.OutputName}");
                }

                if (shows.Count > 0)
                {
                    if (pair.Input != null)
                    {
                        int index = outputs.IndexOf(pair.Input);
                        _typeIndexSelection.Add(pair, index);
                    }
                    else
                    {
                        shows.Insert(0, NONE_SELECTED);
                        _typeIndexSelection.Add(pair, 0);
                    }
                    _typeIndexShow.Add(pair, shows.ToArray());
                }
            }
        }

        public void Hide()
        {
            Active = false;
        }

        protected override void Draw()
        {
            if (_node == null)
            {
                return;
            }
            using (new EditorVerticalLayout("Button"))
            {
                string nodeDesc = EditorGUILayout.TextField("Description", _node.NodeDesc, GUILayout.Height(50));
                if (nodeDesc != _node.NodeDesc)
                {
                    _node.NodeDesc = nodeDesc;
                    OnDataChange?.Invoke();
                }
                
                using (new EditorVerticalLayout("Button"))
                {
                    GUI.SetNextControlName("强制测试用名");
                    foreach (ParamInfo param in _node.Fields)
                    {
                        GUI.SetNextControlName(param.Desc);
                        param.DefaultValue = EditorDataFields.EditorDataField($"{param.Desc}({param.ParamType})", param.DefaultValue, param.ParamType);
                    }
                }

                using (new EditorVerticalLayout("Button"))
                {
                    EditorGUILayout.LabelField("Input");
                    foreach (ParamInfoInput param in _node.Inputs)
                    {
                        string[] datas;
                        try
                        {
                            if (_typeIndexShow.TryGetValue(param, out datas))
                            {
                                string[] shows = _typeIndexShow[param];
                                int index = EditorGUILayout.Popup($"{param.Desc}({param.InputType.Name})", _typeIndexSelection[param], shows);
                                _typeIndexSelection[param] = index;

                                if (shows[index] == NONE_SELECTED)
                                {
                                    continue;
                                }

                                if (shows[0] == NONE_SELECTED)
                                {
                                    --index;
                                }

                                var outp = _outputs[param.InputType][index];
                                if (param.Input != outp)
                                {
                                    param.Input = outp;
                                    param.SrcInputStr = outp.OutputName;
                                    OnDataChange?.Invoke();
                                }
                            }
                            else
                            {
                                EditorGUILayout.LabelField($"Param required is not found.:{param.InputType}");
                            }
                        }
                        catch (NullReferenceException err)
                        {
                            Log.Error(err);
                        }
                    }
                }

                using (new EditorVerticalLayout("Button"))
                {
                    EditorGUILayout.LabelField("Output");
                    foreach (ParamInfoOutput param in _node.Outputs)
                    {
                        string name = EditorDataFields.EditorDataField($"{param.Desc}({param.OutputType})", param.OutputName);
                        if (name != param.OutputName)
                        {
                            param.OutputName = name;
                            OnOutputNameChange?.Invoke();
                        }
                    }
                }
            }
        }
    }
}
