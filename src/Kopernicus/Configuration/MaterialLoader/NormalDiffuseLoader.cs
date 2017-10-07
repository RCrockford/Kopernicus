// Material wrapper generated by shader translator tool
using System;
using Kopernicus.MaterialWrapper;
using UnityEngine;

namespace Kopernicus
{
    namespace Configuration
    {
        [RequireConfigType(ConfigType.Node)]
        public class NormalDiffuseLoader : NormalDiffuse
        {
            // Main Color, default = (1,1,1,1)
            [ParserTarget("color")]
            public ColorParser colorSetter
            {
                get { return color; }
                set { color = value; }
            }

            // Base (RGB), default = "white" { }
            [ParserTarget("mainTex")]
            public Texture2DParser mainTexSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            [ParserTarget("mainTexScale")]
            private Vector2Parser mainTexScaleSetter
            {
                get { return mainTexScale; }
                set { mainTexScale = value; }
            }

            [ParserTarget("mainTexOffset")]
            private Vector2Parser mainTexOffsetSetter
            {
                get { return mainTexOffset; }
                set { mainTexOffset = value; }
            }

            // Constructors
            public NormalDiffuseLoader () : base() { }
            [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
            public NormalDiffuseLoader (String contents) : base (contents) { }
            public NormalDiffuseLoader (Material material) : base(material) { }
        }
    }
}