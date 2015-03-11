///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: Monday, March 9, 2015 4:27:28 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using SquawkTalk.Datalayer;
using SquawkTalk.Datalayer.FactoryClasses;
using SquawkTalk.Datalayer.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SquawkTalk.Datalayer.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Response. </summary>
	public partial class ResponseRelations
	{
		/// <summary>CTor</summary>
		public ResponseRelations()
		{
		}

		/// <summary>Gets all relations of the ResponseEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.FeedEntityUsingFeedGuid);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ResponseEntity and FeedEntity over the m:1 relation they have, using the relation between the fields:
		/// Response.FeedGuid - Feed.Guid
		/// </summary>
		public virtual IEntityRelation FeedEntityUsingFeedGuid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Feed", false);
				relation.AddEntityFieldPair(FeedFields.Guid, ResponseFields.FeedGuid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FeedEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ResponseEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticResponseRelations
	{
		internal static readonly IEntityRelation FeedEntityUsingFeedGuidStatic = new ResponseRelations().FeedEntityUsingFeedGuid;

		/// <summary>CTor</summary>
		static StaticResponseRelations()
		{
		}
	}
}
