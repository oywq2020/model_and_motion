using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XMLController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("sss");
        XmlDocument xml = new XmlDocument();
        
        //read xml file
        xml.Load(Application.dataPath+"/Xml/Hokags.xml");
        
        //get the root node of xml file
        XmlNode root = xml.LastChild;
        
        //get primary node of root
        var rootChildNodes = root.ChildNodes;

        List<XmlElement> xmlElements = new List<XmlElement>();
        foreach (XmlElement hokag in rootChildNodes)
        {
            xmlElements.Add(hokag);
        }

        Debug.Log("sss");
        foreach (var VARIABLE in xmlElements)
        {
            Debug.Log("sss");
            Debug.Log(VARIABLE);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
