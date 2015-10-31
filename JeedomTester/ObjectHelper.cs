using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace JeedomTester
{
    class ObjectHelper
    {
        private static void CreateChildNode(TreeNode parent, object o)
        {
            Type t = o.GetType();

            if (t != typeof(Newtonsoft.Json.Linq.JProperty))
            {
                IList<PropertyInfo> props = new List<PropertyInfo>(t.GetProperties());

                foreach (PropertyInfo prop in props)
                {
                    object propValue = prop.GetValue(o, null);
                    TreeNode tnProp = new TreeNode(prop.Name + " [" + prop.PropertyType.ToString() + "]");
                    string value = propValue == null ? "null" : propValue.ToString();

                    if (value == string.Empty)
                    {
                        value = "No Value Specified";
                    }

                    TreeNode tnValue = new TreeNode(value);

                    if (propValue is ICollection)
                    {
                        IEnumerable items = propValue as IEnumerable;
                        int nodeNo = 0;
                        foreach (object i in items)
                        {
                            nodeNo++;
                            TreeNode tnNo = new TreeNode(nodeNo.ToString());
                            tnProp.Nodes.Add(tnNo);
                            CreateChildNode(tnNo, i);
                        }
                        if (nodeNo == 0)
                        {
                            // Empty collection
                            tnProp.Nodes.Add("Empty");
                        }
                    }
                    else if (propValue != null && propValue.GetType().Module.ScopeName != "CommonLanguageRuntimeLibrary")
                    {
                        if (propValue.GetType().GetProperties().Length > 1)
                        {
                            CreateChildNode(tnProp, propValue);
                        }
                        else
                        {
                            tnProp.Nodes.Add(tnValue);
                        }
                    }
                    else
                    {
                        tnProp.Text += " : " + value;
                    }

                    parent.Nodes.Add(tnProp);
                }
            }
        }

        public static TreeNode CreateTree(object o)
        {
            TreeNode tv = new TreeNode("Objects");

            Type t = o.GetType();

            TreeNode topNode = new TreeNode(t.Name.ToString() + " [" + t.ToString() + "]");

            if (o is ICollection)
            {
                foreach (object i in o as IEnumerable)
                {
                    topNode = new TreeNode(t.Name.ToString() + " : " + t.ToString());
                    CreateChildNode(topNode, i);
                    tv.Nodes.Add(topNode);
                }
            }
            else
            {
                topNode = new TreeNode(t.Name.ToString() + " : " + t.ToString());
                CreateChildNode(topNode, o);
                tv.Nodes.Add(topNode);
            }

            return tv;
        }
    }
}
