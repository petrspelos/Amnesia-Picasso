﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AmnesiaPicasso
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\petrs\OneDrive\Dokumenty\GitHub\AmnesiaPicasso\AmnesiaPicasso\painting_diego_dae.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class painting_diego_dae : painting_diego_daeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<COLLADA xmlns=""http://www.collada.org/2005/11/COLLADASchema"" version=""1.4.1"">
  <asset>
    <contributor>
      <author></author>
      <authoring_tool>Amnesia Picasso</authoring_tool>
      <comments></comments>
      <source_data></source_data>
    </contributor>
    <created>2009-04-23T09:29:04Z</created>
    <modified>2009-04-23T09:29:04Z</modified>
    <unit meter=""1.0"" name=""meter""/>
    <up_axis>Y_UP</up_axis>
  </asset>
  <library_physics_scenes>
    <physics_scene id=""MayaNativePhysicsScene"">
      <technique_common>
        <gravity>0 -980 0</gravity>
        <time_step>0.083</time_step>
      </technique_common>
    </physics_scene>
  </library_physics_scenes>
  <library_images>
    <image id=""file1"" name=""file1"">
      <init_from>./");
            
            #line 6 "C:\Users\petrs\OneDrive\Dokumenty\GitHub\AmnesiaPicasso\AmnesiaPicasso\painting_diego_dae.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextureName));
            
            #line default
            #line hidden
            this.Write(".tga</init_from>\n      <extra>\n        <technique profile=\"MAYA\">\n          <dgno" +
                    "de_type>kFile</dgnode_type>\n          <image_sequence>0</image_sequence>\n       " +
                    " </technique>\n      </extra>\n    </image>\n  </library_images>\n  <library_materia" +
                    "ls>\n    <material id=\"lambert2\" name=\"lambert2\">\n      <instance_effect url=\"#la" +
                    "mbert2-fx\"/>\n    </material>\n    <material id=\"lambert3\" name=\"lambert3\">\n      " +
                    "<instance_effect url=\"#lambert3-fx\"/>\n    </material>\n  </library_materials>\n  <" +
                    "library_effects>\n    <effect id=\"lambert2-fx\">\n      <profile_COMMON>\n        <t" +
                    "echnique sid=\"common\">\n          <lambert>\n            <emission>\n              " +
                    "<color>0 0 0 1</color>\n            </emission>\n            <ambient>\n           " +
                    "   <color>0 0 0 1</color>\n            </ambient>\n            <diffuse>\n         " +
                    "     <color>0.8 0.8 0.8 0.8</color>\n            </diffuse>\n            <transpar" +
                    "ent opaque=\"RGB_ZERO\">\n              <color>0 0 0 1</color>\n            </transp" +
                    "arent>\n            <transparency>\n              <float>1</float>\n            </t" +
                    "ransparency>\n          </lambert>\n          <extra>\n            <technique profi" +
                    "le=\"FCOLLADA\"/>\n          </extra>\n        </technique>\n      </profile_COMMON>\n" +
                    "    </effect>\n    <effect id=\"lambert3-fx\">\n      <profile_COMMON>\n        <newp" +
                    "aram sid=\"file1-surface\">\n          <surface type=\"2D\">\n            <init_from>f" +
                    "ile1</init_from>\n            <format>A8R8G8B8</format>\n          </surface>\n    " +
                    "    </newparam>\n        <newparam sid=\"file1-sampler\">\n          <sampler2D>\n   " +
                    "         <source>file1-surface</source>\n            <wrap_s>WRAP</wrap_s>\n      " +
                    "      <wrap_t>WRAP</wrap_t>\n            <minfilter>NONE</minfilter>\n            " +
                    "<magfilter>NONE</magfilter>\n            <mipfilter>NONE</mipfilter>\n          </" +
                    "sampler2D>\n        </newparam>\n        <technique sid=\"common\">\n          <lambe" +
                    "rt>\n            <emission>\n              <color>0 0 0 1</color>\n            </em" +
                    "ission>\n            <ambient>\n              <color>0 0 0 1</color>\n            <" +
                    "/ambient>\n            <diffuse>\n              <texture texture=\"file1-sampler\" t" +
                    "excoord=\"TEX0\">\n                <extra>\n                  <technique profile=\"MA" +
                    "YA\">\n                    <wrapU>1</wrapU>\n                    <wrapV>1</wrapV>\n " +
                    "                   <mirrorU>0</mirrorU>\n                    <mirrorV>0</mirrorV>" +
                    "\n                    <coverageU>1</coverageU>\n                    <coverageV>1</" +
                    "coverageV>\n                    <translateFrameU>0</translateFrameU>\n            " +
                    "        <translateFrameV>0</translateFrameV>\n                    <rotateFrame>0<" +
                    "/rotateFrame>\n                    <stagger>0</stagger>\n                    <fast" +
                    ">0</fast>\n                    <repeatU>1</repeatU>\n                    <repeatV>" +
                    "1</repeatV>\n                    <offsetU>0</offsetU>\n                    <offset" +
                    "V>0</offsetV>\n                    <rotateUV>0</rotateUV>\n                    <no" +
                    "iseU>0</noiseU>\n                    <noiseV>0</noiseV>\n                    <blen" +
                    "d_mode>NONE</blend_mode>\n                  </technique>\n                </extra>" +
                    "\n              </texture>\n            </diffuse>\n            <transparent opaque" +
                    "=\"RGB_ZERO\">\n              <color>0 0 0 1</color>\n            </transparent>\n   " +
                    "         <transparency>\n              <float>1</float>\n            </transparenc" +
                    "y>\n          </lambert>\n          <extra>\n            <technique profile=\"FCOLLA" +
                    "DA\"/>\n          </extra>\n        </technique>\n      </profile_COMMON>\n    </effe" +
                    "ct>\n  </library_effects>\n  <library_geometries>\n    <geometry id=\"pPlaneShape1\" " +
                    "name=\"pPlaneShape1\">\n      <mesh>\n        <source id=\"pPlaneShape1-positions\" na" +
                    "me=\"position\">\n          <float_array id=\"pPlaneShape1-positions-array\" count=\"1" +
                    "08\">-1 0 -0.058554 0.999936 -0.000076 -0.058554 -1.00003 1.99997 -0.058554 1.000" +
                    "09 1.99989 -0.058554 -0.977416 0.022582 0.002494 0.977355 0.022507 0.002494 -0.9" +
                    "77441 1.97738 0.002494 0.977508 1.97731 0.002494 -0.949186 0.050809 0.029277 0.9" +
                    "49129 0.050737 0.029277 -0.949211 1.94915 0.029277 0.949277 1.94908 0.029277 -0." +
                    "911546 0.088446 0.029277 0.911494 0.088377 0.029277 -0.911569 1.91151 0.029277 0" +
                    ".911636 1.91144 0.029277 -0.885198 0.114792 0.010646 0.885149 0.114725 0.010646 " +
                    "-0.885221 1.88517 0.010646 0.885287 1.8851 0.010646 -0.851321 0.148665 0.021292 " +
                    "0.851277 0.148601 0.021292 -0.851344 1.85129 0.021292 0.85141 1.85122 0.021292 -" +
                    "0.823091 0.176893 0 0.823051 0.176831 0 -0.823113 1.82306 0 0.823179 1.823 0 -0." +
                    "82131 0.178675 -0.058554 0.821269 0.178612 -0.058554 -0.821331 1.82128 -0.058554" +
                    " 0.821398 1.82121 -0.058554 -0.82131 0.178675 -0.019753 0.821269 0.178612 -0.019" +
                    "753 -0.821331 1.82128 -0.019753 0.821398 1.82121 -0.019753</float_array>\n       " +
                    "   <technique_common>\n            <accessor source=\"#pPlaneShape1-positions-arra" +
                    "y\" count=\"36\" stride=\"3\">\n              <param name=\"X\" type=\"float\"/>\n         " +
                    "     <param name=\"Y\" type=\"float\"/>\n              <param name=\"Z\" type=\"float\"/>" +
                    "\n            </accessor>\n          </technique_common>\n        </source>\n       " +
                    " <source id=\"pPlaneShape1-normals\" name=\"normal\">\n          <float_array id=\"pPl" +
                    "aneShape1-normals-array\" count=\"264\">-0.000035 -0.937888 0.346937 -0.000035 -0.9" +
                    "37888 0.346937 -0.000035 -0.937888 0.346937 -0.000035 -0.937888 0.346937 -0.9378" +
                    "81 -0.000012 0.346956 -0.937881 -0.000012 0.346956 -0.937881 -0.000012 0.346956 " +
                    "-0.937881 -0.000012 0.346956 0.937889 -0.000073 0.346936 0.937889 -0.000073 0.34" +
                    "6936 0.937889 -0.000073 0.346936 0.937889 -0.000073 0.346937 0.000037 0.937889 0" +
                    ".346936 0.000037 0.937889 0.346936 0.000037 0.937889 0.346936 0.000037 0.937888 " +
                    "0.346937 0.516419 -0.258255 0.816465 0.258195 -0.516449 0.816466 -0.258224 -0.51" +
                    "6429 0.816469 -0.516418 -0.258219 0.816477 -0.516405 0.258209 0.816489 -0.258187" +
                    " 0.516428 0.816481 0.258238 0.516413 0.816475 0.516445 0.258176 0.816474 0 0 1 0" +
                    " 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 -0.417039 0.208555 0.884637 -0.208507 0" +
                    ".417062 0.884638 0.208529 0.417046 0.88464 0.417034 0.208527 0.884646 0.417022 -" +
                    "0.208518 0.884654 0.208499 -0.417043 0.884649 -0.208541 -0.417031 0.884645 -0.41" +
                    "7057 -0.20849 0.884644 0.203999 -0.102017 0.973641 0.101993 -0.20401 0.973641 -0" +
                    ".102003 -0.204003 0.973642 -0.203994 -0.102004 0.973643 -0.203987 0.101999 0.973" +
                    "646 -0.101987 0.204001 0.973644 0.102009 0.203995 0.973643 0.204007 0.101985 0.9" +
                    "73643 -0.438325 0.2192 0.871678 -0.21915 0.438349 0.871678 0.219173 0.438333 0.8" +
                    "71681 0.438321 0.219171 0.871688 0.438308 -0.219163 0.871696 0.219141 -0.438331 " +
                    "0.87169 -0.219185 -0.438318 0.871685 -0.438345 -0.219132 0.871685 0 0 1 0 0 1 0 " +
                    "0 1 0 0 1 0 0 -1 0 0 -1 0 0 -1 0 0 -1 0 0 -1 0 0 -1 0 0 -1 0 0 -1 0.000038 1 0 0" +
                    ".000038 1 0 0.000038 1 0 0.000038 1 0 1 0.000013 0 1 0.000013 0 1 0.000013 0 1 0" +
                    ".000013 0 -1 0.000078 0 -1 0.000078 0 -1 0.000078 0 -1 0.000078 0 -0.000039 -1 0" +
                    " -0.000039 -1 0 -0.000039 -1 0 -0.000039 -1 0 0 0 -1 0 0 -1 0 0 -1 0 0 -1</float" +
                    "_array>\n          <technique_common>\n            <accessor source=\"#pPlaneShape1" +
                    "-normals-array\" count=\"88\" stride=\"3\">\n              <param name=\"X\" type=\"float" +
                    "\"/>\n              <param name=\"Y\" type=\"float\"/>\n              <param name=\"Z\" t" +
                    "ype=\"float\"/>\n            </accessor>\n          </technique_common>\n        </so" +
                    "urce>\n        <source id=\"pPlaneShape1-map1\" name=\"map1\">\n          <float_array" +
                    " id=\"pPlaneShape1-map1-array\" count=\"126\">0.889547 0.10834 0.879566 0.118323 0.0" +
                    "15514 0.118355 0.005532 0.108374 0.015503 0.98242 0.00552 0.992402 0.889616 0.99" +
                    "2367 0.879633 0.982386 0.867089 0.130801 0.027993 0.130833 0.027982 0.969942 0.8" +
                    "67155 0.969908 0.850454 0.147438 0.04463 0.147469 0.04462 0.953304 0.850517 0.95" +
                    "3272 0.838809 0.159085 0.056277 0.159114 0.056267 0.941658 0.83887 0.941627 0.82" +
                    "3837 0.174058 0.071251 0.174087 0.071241 0.926684 0.823895 0.926654 0.81136 0.18" +
                    "6537 0.800259 0.197685 0.800314 0.905374 0.811417 0.914177 0.885294 0.071369 0.8" +
                    "45301 0.031375 0.999112 0.002788 0.477655 0.031375 0.437664 0.071369 0.904108 0." +
                    "097795 0.999119 0.097792 0.017148 0.031375 0.904109 0.002791 0.999112 0.002788 0" +
                    ".904108 0.097795 0.999119 0.097792 0.932094 0.553169 0.97153 0.514261 0.97153 0." +
                    "156606 0.932094 0.117703 0.97153 0.540181 0.932094 0.57909 0.932094 0.936777 0.9" +
                    "7153 0.975686 0.97153 0.514261 0.97153 0.156606 0.057141 0.071369 0.424787 0.071" +
                    "369 0.464778 0.031375 0.845301 0.031375 0.477655 0.031375 0.08372 0.914206 0.083" +
                    "72 0.914206 0.811417 0.914177 0.09257 0.905402 0.81136 0.186537 0.092579 0.19771" +
                    "2 0.083729 0.186564 0.083729 0.186564</float_array>\n          <technique_common>" +
                    "\n            <accessor source=\"#pPlaneShape1-map1-array\" count=\"63\" stride=\"2\">\n" +
                    "              <param name=\"S\" type=\"float\"/>\n              <param name=\"T\" type=" +
                    "\"float\"/>\n            </accessor>\n          </technique_common>\n        </source" +
                    ">\n        <vertices id=\"pPlaneShape1-vertices\">\n          <input semantic=\"POSIT" +
                    "ION\" source=\"#pPlaneShape1-positions\"/>\n        </vertices>\n        <triangles m" +
                    "aterial=\"lambert3SG\" count=\"68\">\n          <input semantic=\"VERTEX\" source=\"#pPl" +
                    "aneShape1-vertices\" offset=\"0\"/>\n          <input semantic=\"NORMAL\" source=\"#pPl" +
                    "aneShape1-normals\" offset=\"1\"/>\n          <input semantic=\"TEXCOORD\" source=\"#pP" +
                    "laneShape1-map1\" offset=\"2\" set=\"0\"/>\n          <p>1 0 0 5 1 1 0 2 3 0 2 3 5 1 1" +
                    " 4 3 2 0 4 3 4 5 2 2 6 5 2 6 5 4 5 2 6 7 4 3 8 6 7 9 7 1 10 0 1 10 0 7 9 7 5 11 " +
                    "1 2 12 5 6 13 4 3 14 6 3 14 6 6 13 4 7 15 7 5 16 1 9 17 8 4 18 2 4 18 2 9 17 8 8" +
                    " 19 9 4 18 2 8 19 9 6 20 4 6 20 4 8 19 9 10 21 10 7 22 7 11 23 11 5 16 1 5 16 1 " +
                    "11 23 11 9 17 8 6 20 4 10 21 10 7 22 7 7 22 7 10 21 10 11 23 11 9 24 8 13 25 12 " +
                    "8 26 9 8 26 9 13 25 12 12 27 13 8 26 9 12 27 13 10 28 10 10 28 10 12 27 13 14 29" +
                    " 14 11 30 11 15 31 15 9 24 8 9 24 8 15 31 15 13 25 12 10 28 10 14 29 14 11 30 11" +
                    " 11 30 11 14 29 14 15 31 15 13 32 12 17 33 16 12 34 13 12 34 13 17 33 16 16 35 1" +
                    "7 12 34 13 16 35 17 14 36 14 14 36 14 16 35 17 18 37 18 15 38 15 19 39 19 13 32 " +
                    "12 13 32 12 19 39 19 17 33 16 14 36 14 18 37 18 15 38 15 15 38 15 18 37 18 19 39" +
                    " 19 17 40 16 21 41 20 16 42 17 16 42 17 21 41 20 20 43 21 16 42 17 20 43 21 18 4" +
                    "4 18 18 44 18 20 43 21 22 45 22 19 46 19 23 47 23 17 40 16 17 40 16 23 47 23 21 " +
                    "41 20 18 44 18 22 45 22 19 46 19 19 46 19 22 45 22 23 47 23 21 48 20 25 49 59 20" +
                    " 50 21 20 50 21 25 49 59 24 51 61 20 50 21 24 51 62 22 52 22 22 52 22 24 51 62 2" +
                    "6 53 55 23 54 23 27 55 57 21 48 20 21 48 20 27 55 57 25 49 24 22 52 22 26 53 56 " +
                    "23 54 23 23 54 23 26 53 56 27 55 27 25 56 25 27 57 26 24 58 60 24 58 60 27 57 26" +
                    " 26 59 58 0 60 40 28 61 41 1 62 43 1 62 43 28 61 41 29 63 42 2 64 28 30 65 29 0 " +
                    "60 32 0 60 32 30 65 29 28 61 31 1 62 35 29 63 50 3 66 52 3 66 52 29 63 50 31 67 " +
                    "51 3 66 44 31 67 45 2 64 47 2 64 47 31 67 45 30 65 46 28 68 41 32 69 48 29 70 42" +
                    " 29 70 42 32 69 48 33 71 49 30 72 29 34 73 53 28 74 31 28 74 31 34 73 53 32 75 5" +
                    "4 29 76 30 33 77 37 31 78 34 31 78 34 33 77 37 35 79 39 31 80 34 35 81 39 30 82 " +
                    "33 30 82 33 35 81 39 34 83 38 33 84 37 32 85 36 35 86 39 35 86 39 32 85 36 34 87" +
                    " 38</p>\n        </triangles>\n      </mesh>\n      <extra>\n        <technique prof" +
                    "ile=\"MAYA\">\n          <double_sided>0</double_sided>\n          <dynamic_attribut" +
                    "es>\n            <miShadingSamplesOverride short_name=\"mso\" type=\"bool\">0</miShad" +
                    "ingSamplesOverride>\n            <miShadingSamples short_name=\"msh\" type=\"float\">" +
                    "0</miShadingSamples>\n            <miMaxDisplaceOverride short_name=\"mdo\" type=\"b" +
                    "ool\">0</miMaxDisplaceOverride>\n            <miMaxDisplace short_name=\"mmd\" type=" +
                    "\"float\">0</miMaxDisplace>\n          </dynamic_attributes>\n        </technique>\n " +
                    "     </extra>\n    </geometry>\n  </library_geometries>\n  <library_visual_scenes>\n" +
                    "    <visual_scene id=\"VisualSceneNode\" name=\"painting_diego_church\">\n      <node" +
                    " id=\"pPlane1\" name=\"pPlane1\" type=\"NODE\">\n        <rotate sid=\"rotateZ\">0 0 1 0<" +
                    "/rotate>\n        <rotate sid=\"rotateY\">0 1 0 0</rotate>\n        <rotate sid=\"rot" +
                    "ateX\">1 0 0 0</rotate>\n        <instance_geometry url=\"#pPlaneShape1\">\n         " +
                    " <bind_material>\n            <technique_common>\n              <instance_material" +
                    " symbol=\"lambert3SG\" target=\"#lambert3\">\n                <bind_vertex_input sema" +
                    "ntic=\"TEX0\" input_semantic=\"TEXCOORD\" input_set=\"0\"/>\n              </instance_m" +
                    "aterial>\n            </technique_common>\n          </bind_material>\n        </in" +
                    "stance_geometry>\n      </node>\n      <extra>\n        <technique profile=\"FCOLLAD" +
                    "A\">\n          <start_time>0.041666</start_time>\n          <end_time>2</end_time>" +
                    "\n        </technique>\n      </extra>\n    </visual_scene>\n  </library_visual_scen" +
                    "es>\n  <scene>\n    <instance_physics_scene url=\"#MayaNativePhysicsScene\"/>\n    <i" +
                    "nstance_visual_scene url=\"#VisualSceneNode\"/>\n  </scene>\n</COLLADA>\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 6 "C:\Users\petrs\OneDrive\Dokumenty\GitHub\AmnesiaPicasso\AmnesiaPicasso\painting_diego_dae.tt"

public string TextureName { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class painting_diego_daeBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
