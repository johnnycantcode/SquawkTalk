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
	/// <summary>Implements the relations factory for the entity: Feed. </summary>
	public partial class FeedRelations
	{
		/// <summary>CTor</summary>
		public FeedRelations()
		{
		}

		/// <summary>Gets all relations of the FeedEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ResponseEntityUsingFeedGuid);
			toReturn.Add(this.PersonEntityUsingPersonGuid);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between FeedEntity and ResponseEntity over the 1:n relation they have, using the relation between the fields:
		/// Feed.Guid - Response.FeedGuid
		/// </summary>
		public virtual IEntityRelation ResponseEntityUsingFeedGuid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Responses" , true);
				relation.AddEntityFieldPair(FeedFields.Guid, ResponseFields.FeedGuid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FeedEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ResponseEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between FeedEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// Feed.PersonGuid - Person.Guid
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingPersonGuid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.Guid, FeedFields.PersonGuid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FeedEntity", true);
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
	internal static class StaticFeedRelations
	{
		internal static readonly IEntityRelation ResponseEntityUsingFeedGuidStatic = new FeedRelations().ResponseEntityUsingFeedGuid;
		internal static readonly IEntityRelation PersonEntityUsingPersonGuidStatic = new FeedRelations().PersonEntityUsingPersonGuid;

		/// <summary>CTor</summary>
		static StaticFeedRelations()
		{
		}
	}
}
