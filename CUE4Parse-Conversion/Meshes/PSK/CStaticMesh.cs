﻿namespace CUE4Parse_Conversion.Meshes.PSK
{
    public class CStaticMesh
    {
        public CStaticMeshLod[] LODs;

        public CStaticMesh()
        {
            LODs = new CStaticMeshLod[0];
        }
        
        public CStaticMesh(CStaticMeshLod[] lods)
        {
            LODs = lods;
        }
        
        public void FinalizeMesh()
        {
            foreach (var levelOfDetail in LODs)
            {
                levelOfDetail.BuildNormals();
            }
        }
    }
}