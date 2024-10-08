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
	/// <summary>Projects Page</summary>
	[PublishedModel("projectsPage")]
	public partial class ProjectsPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "projectsPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProjectsPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProjectsPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Our Projects Project 1 Btn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject1Btn")]
		public virtual string OurProjectsProject1Btn => this.Value<string>(_publishedValueFallback, "ourProjectsProject1Btn");

		///<summary>
		/// Our Projects Project 1 Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject1Date")]
		public virtual string OurProjectsProject1Date => this.Value<string>(_publishedValueFallback, "ourProjectsProject1Date");

		///<summary>
		/// Our Projects Project 1 Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject1Headline")]
		public virtual string OurProjectsProject1Headline => this.Value<string>(_publishedValueFallback, "ourProjectsProject1Headline");

		///<summary>
		/// Our Projects Project 1 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject1Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectsProject1Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectsProject1Img");

		///<summary>
		/// Our Projects Project 1 Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject1Link")]
		public virtual string OurProjectsProject1Link => this.Value<string>(_publishedValueFallback, "ourProjectsProject1Link");

		///<summary>
		/// Our Projects Project 1 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject1Text")]
		public virtual string OurProjectsProject1Text => this.Value<string>(_publishedValueFallback, "ourProjectsProject1Text");

		///<summary>
		/// Our Projects Project 2 Btn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject2Btn")]
		public virtual string OurProjectsProject2Btn => this.Value<string>(_publishedValueFallback, "ourProjectsProject2Btn");

		///<summary>
		/// Our Projects Project 2 Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject2Date")]
		public virtual string OurProjectsProject2Date => this.Value<string>(_publishedValueFallback, "ourProjectsProject2Date");

		///<summary>
		/// Our Projects Project 2 Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject2Headline")]
		public virtual string OurProjectsProject2Headline => this.Value<string>(_publishedValueFallback, "ourProjectsProject2Headline");

		///<summary>
		/// Our Projects Project 2Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject2Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectsProject2Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectsProject2Img");

		///<summary>
		/// Our Projects Project 2 Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject2Link")]
		public virtual string OurProjectsProject2Link => this.Value<string>(_publishedValueFallback, "ourProjectsProject2Link");

		///<summary>
		/// Our Projects Project 2 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject2Text")]
		public virtual string OurProjectsProject2Text => this.Value<string>(_publishedValueFallback, "ourProjectsProject2Text");

		///<summary>
		/// Our Projects Project 3 Btn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject3Btn")]
		public virtual string OurProjectsProject3Btn => this.Value<string>(_publishedValueFallback, "ourProjectsProject3Btn");

		///<summary>
		/// Our Projects Project 3 Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject3Date")]
		public virtual string OurProjectsProject3Date => this.Value<string>(_publishedValueFallback, "ourProjectsProject3Date");

		///<summary>
		/// Our Projects Project 3Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject3Headline")]
		public virtual string OurProjectsProject3Headline => this.Value<string>(_publishedValueFallback, "ourProjectsProject3Headline");

		///<summary>
		/// Our Projects Project 3Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject3Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectsProject3Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectsProject3Img");

		///<summary>
		/// Our Projects Project 3 Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject3Link")]
		public virtual string OurProjectsProject3Link => this.Value<string>(_publishedValueFallback, "ourProjectsProject3Link");

		///<summary>
		/// Our Projects Project 3 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject3Text")]
		public virtual string OurProjectsProject3Text => this.Value<string>(_publishedValueFallback, "ourProjectsProject3Text");

		///<summary>
		/// Our Projects Project 4 Btn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject4Btn")]
		public virtual string OurProjectsProject4Btn => this.Value<string>(_publishedValueFallback, "ourProjectsProject4Btn");

		///<summary>
		/// Our Projects Project 4 Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject4Date")]
		public virtual string OurProjectsProject4Date => this.Value<string>(_publishedValueFallback, "ourProjectsProject4Date");

		///<summary>
		/// Our Projects Project 4 Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject4Headline")]
		public virtual string OurProjectsProject4Headline => this.Value<string>(_publishedValueFallback, "ourProjectsProject4Headline");

		///<summary>
		/// Our Projects Project 4 Img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject4Img")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectsProject4Img => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectsProject4Img");

		///<summary>
		/// Our Projects Project 4 Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject4Link")]
		public virtual string OurProjectsProject4Link => this.Value<string>(_publishedValueFallback, "ourProjectsProject4Link");

		///<summary>
		/// Our Projects Project 4 Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectsProject4Text")]
		public virtual string OurProjectsProject4Text => this.Value<string>(_publishedValueFallback, "ourProjectsProject4Text");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Projects Banner Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBannerHeadline")]
		public virtual string ProjectsBannerHeadline => this.Value<string>(_publishedValueFallback, "projectsBannerHeadline");

		///<summary>
		/// Projects Banner Link2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBannerLink2")]
		public virtual string ProjectsBannerLink2 => this.Value<string>(_publishedValueFallback, "projectsBannerLink2");

		///<summary>
		/// Projects Banner Link Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBannerLinkText2")]
		public virtual string ProjectsBannerLinkText2 => this.Value<string>(_publishedValueFallback, "projectsBannerLinkText2");
	}
}
