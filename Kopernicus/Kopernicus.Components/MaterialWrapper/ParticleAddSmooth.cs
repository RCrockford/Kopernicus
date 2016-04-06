// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class ParticleAddSmooth : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                private const string shaderName = "Particles/Additive (Soft)";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Particle Texture, default = "white" { }
                public const string mainTexKey = "_MainTex";
                public int mainTexID { get; private set; }

                // Soft Particles Factor, default = 1
                public const string invFadeKey = "_InvFade";
                public int invFadeID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
                    get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
                    mainTexID = Shader.PropertyToID(mainTexKey);
                    invFadeID = Shader.PropertyToID(invFadeKey);
                }
            }

            // Particle Texture, default = "white" { }
            public Texture2D mainTex
            {
                get { return GetTexture (Properties.Instance.mainTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.mainTexID, value); }
            }

            public Vector2 mainTexScale
            {
                get { return GetTextureScale (Properties.mainTexKey); }
                set { SetTextureScale (Properties.mainTexKey, value); }
            }

            public Vector2 mainTexOffset
            {
                get { return GetTextureOffset (Properties.mainTexKey); }
                set { SetTextureOffset (Properties.mainTexKey, value); }
            }

            // Soft Particles Factor, default = 1
            public float invFade
            {
                get { return GetFloat (Properties.Instance.invFadeID); }
                set { SetFloat (Properties.Instance.invFadeID, Mathf.Clamp(value,0.01f,3f)); }
            }

            public ParticleAddSmooth() : base(Properties.shader)
            {
            }

            public ParticleAddSmooth(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public ParticleAddSmooth(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Particles/Additive (Soft) shader required");
            }

        }
    }
}