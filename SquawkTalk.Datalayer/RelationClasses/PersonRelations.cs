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
	/// <summary>Implements the relations factory for the entity: Person. </summary>
	public partial class PersonRelations
	{
		/// <summary>CTor</summary>
		public PersonRelations()
		{
		}

		/// <summary>Gets all relations of the PersonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmailTemplateEntityUsingPersonGuid);
			toReturn.Add(this.FeedEntityUsingPersonGuid);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and EmailTemplateEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.Guid - EmailTemplate.PersonGuid
		/// </summary>
		public virtual IEntityRelation EmailTemplateEntityUsingPersonGuid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmailTemplates" , true);
				relation.AddEntityFieldPair(PersonFields.Guid, EmailTemplateFields.PersonGuid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmailTemplateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and FeedEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.Guid - Feed.PersonGuid
		/// </summary>
		public virtual IEntityRelation FeedEntityUsingPersonGuid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Feeds" , true);
				relation.AddEntityFieldPair(PersonFields.Guid, FeedFields.PersonGuid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("FeedEntity", false);
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
	internal static class StaticPersonRelations
	{
		internal static readonly IEntityRelation EmailTemplateEntityUsingPersonGuidStatic = new PersonRelations().EmailTemplateEntityUsingPersonGuid;
		internal static readonly IEntityRelation FeedEntityUsingPersonGuidStatic = new PersonRelations().FeedEntityUsingPersonGuid;

		/// <summary>CTor</summary>
		static StaticPersonRelations()
		{
		}
	}
}
