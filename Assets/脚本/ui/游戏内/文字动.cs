using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class 文字动 : MonoBehaviour
{
   public TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.ForceMeshUpdate();
        var textInfo = text.textInfo; 
        for(int i = 0;i<textInfo.characterCount;i++)
        {
            var charInfo = textInfo.characterInfo[i];
            if(!charInfo.isVisible)
                continue;
            var verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;
            for (int j = 0; j<4;j++)
            {
                var orig = verts[charInfo.vertexIndex+j];
                //动画
                verts[charInfo.vertexIndex + j] = orig + new Vector3(0,Mathf.Sin(Time.deltaTime*2f+orig.x*0.45f)*3,0);
            }
            
        }
        for(int i = 0;i < textInfo.meshInfo.Length;i++)
        {
            var meshInfo = textInfo.meshInfo[i];
            meshInfo.mesh.vertices = meshInfo.vertices;
            text.UpdateGeometry(meshInfo.mesh, i);
        }
    }
}
