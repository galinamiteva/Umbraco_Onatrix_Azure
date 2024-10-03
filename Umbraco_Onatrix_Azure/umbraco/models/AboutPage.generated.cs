//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>About Page</summary>
	[PublishedModel("aboutPage")]
	public partial class AboutPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "aboutPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AboutPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AboutPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// About Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutHeadline")]
		public virtual string AboutHeadline => this.Value<string>(_publishedValueFallback, "aboutHeadline");

		///<summary>
		/// About Link2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutLink2")]
		public virtual string AboutLink2 => this.Value<string>(_publishedValueFallback, "aboutLink2");

		///<summary>
		/// About Link Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutLinkText2")]
		public virtual string AboutLinkText2 => this.Value<string>(_publishedValueFallback, "aboutLinkText2");

		///<summary>
		/// Kevin Bank
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("kevinBank")]
		public virtual string KevinBank => this.Value<string>(_publishedValueFallback, "kevinBank");

		///<summary>
		/// Kevin Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("kevinHeading")]
		public virtual string KevinHeading => this.Value<string>(_publishedValueFallback, "kevinHeading");

		///<summary>
		/// Kevin Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("kevinHeadline")]
		public virtual string KevinHeadline => this.Value<string>(_publishedValueFallback, "kevinHeadline");

		///<summary>
		/// Kevin Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("kevinImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops KevinImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "kevinImg");

		///<summary>
		/// Kevin Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("kevinName")]
		public virtual string KevinName => this.Value<string>(_publishedValueFallback, "kevinName");

		///<summary>
		/// Kevin Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("kevinText")]
		public virtual string KevinText => this.Value<string>(_publishedValueFallback, "kevinText");

		///<summary>
		/// Our Experts Expert1 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert1Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsExpert1Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsExpert1Img");

		///<summary>
		/// Our Experts Expert1 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert1Name")]
		public virtual string OurExpertsExpert1Name => this.Value<string>(_publishedValueFallback, "ourExpertsExpert1Name");

		///<summary>
		/// Our Experts Expert1 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert1Text")]
		public virtual string OurExpertsExpert1Text => this.Value<string>(_publishedValueFallback, "ourExpertsExpert1Text");

		///<summary>
		/// Our Experts Expert2 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert2Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsExpert2Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsExpert2Img");

		///<summary>
		/// Our Experts Expert2 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert2Name")]
		public virtual string OurExpertsExpert2Name => this.Value<string>(_publishedValueFallback, "ourExpertsExpert2Name");

		///<summary>
		/// Our Experts Expert2 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert2Text")]
		public virtual string OurExpertsExpert2Text => this.Value<string>(_publishedValueFallback, "ourExpertsExpert2Text");

		///<summary>
		/// Our Experts Expert3 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert3Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsExpert3Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsExpert3Img");

		///<summary>
		/// Our Experts Expert3 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert3Name")]
		public virtual string OurExpertsExpert3Name => this.Value<string>(_publishedValueFallback, "ourExpertsExpert3Name");

		///<summary>
		/// Our Experts Expert3 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsExpert3Text")]
		public virtual string OurExpertsExpert3Text => this.Value<string>(_publishedValueFallback, "ourExpertsExpert3Text");

		///<summary>
		/// Our Experts Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsHeading")]
		public virtual string OurExpertsHeading => this.Value<string>(_publishedValueFallback, "ourExpertsHeading");

		///<summary>
		/// Our Experts Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsHeadline")]
		public virtual string OurExpertsHeadline => this.Value<string>(_publishedValueFallback, "ourExpertsHeadline");

		///<summary>
		/// Our Experts More Expert1 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert1Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsMoreExpert1Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsMoreExpert1Img");

		///<summary>
		/// Our Experts More Expert1 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert1Name")]
		public virtual string OurExpertsMoreExpert1Name => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert1Name");

		///<summary>
		/// Our Experts More Expert1 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert1Text")]
		public virtual string OurExpertsMoreExpert1Text => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert1Text");

		///<summary>
		/// Our Experts More Expert2 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert2Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsMoreExpert2Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsMoreExpert2Img");

		///<summary>
		/// Our Experts More Expert2 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert2Name")]
		public virtual string OurExpertsMoreExpert2Name => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert2Name");

		///<summary>
		/// Our Experts More Expert2 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert2Text")]
		public virtual string OurExpertsMoreExpert2Text => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert2Text");

		///<summary>
		/// Our Experts More Expert3 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert3Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsMoreExpert3Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsMoreExpert3Img");

		///<summary>
		/// Our Experts More Expert3 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert3Name")]
		public virtual string OurExpertsMoreExpert3Name => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert3Name");

		///<summary>
		/// Our Experts More Expert3 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert3Text")]
		public virtual string OurExpertsMoreExpert3Text => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert3Text");

		///<summary>
		/// Our Experts  More Expert 4 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert4Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertsMoreExpert4Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertsMoreExpert4Img");

		///<summary>
		/// Our Experts  More Expert 4 Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert4Name")]
		public virtual string OurExpertsMoreExpert4Name => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert4Name");

		///<summary>
		/// Our Experts  More Expert 4 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertsMoreExpert4Text")]
		public virtual string OurExpertsMoreExpert4Text => this.Value<string>(_publishedValueFallback, "ourExpertsMoreExpert4Text");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Tina Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaHeadline")]
		public virtual string TinaHeadline => this.Value<string>(_publishedValueFallback, "tinaHeadline");

		///<summary>
		/// Tina Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops TinaImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "tinaImg");

		///<summary>
		/// Tina Quote
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaQuote")]
		public virtual string TinaQuote => this.Value<string>(_publishedValueFallback, "tinaQuote");

		///<summary>
		/// Tina Text1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText1")]
		public virtual string TinaText1 => this.Value<string>(_publishedValueFallback, "tinaText1");

		///<summary>
		/// Tina Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText2")]
		public virtual string TinaText2 => this.Value<string>(_publishedValueFallback, "tinaText2");

		///<summary>
		/// Tina Text3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText3")]
		public virtual string TinaText3 => this.Value<string>(_publishedValueFallback, "tinaText3");

		///<summary>
		/// Tina Text4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText4")]
		public virtual string TinaText4 => this.Value<string>(_publishedValueFallback, "tinaText4");

		///<summary>
		/// Tina Text5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText5")]
		public virtual string TinaText5 => this.Value<string>(_publishedValueFallback, "tinaText5");

		///<summary>
		/// Tina Text6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText6")]
		public virtual string TinaText6 => this.Value<string>(_publishedValueFallback, "tinaText6");

		///<summary>
		/// Tina Text7
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tinaText7")]
		public virtual string TinaText7 => this.Value<string>(_publishedValueFallback, "tinaText7");
	}
}
