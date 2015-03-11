///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: Monday, March 9, 2015 4:27:29 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SquawkTalk.Datalayer.FactoryClasses;
using SquawkTalk.Datalayer;

namespace SquawkTalk.Datalayer.HelperClasses
{
	/// <summary>Field Creation Class for entity EmailTemplateEntity</summary>
	public partial class EmailTemplateFields
	{
		/// <summary>Creates a new EmailTemplateEntity.Guid field instance</summary>
		public static EntityField Guid
		{
			get { return (EntityField)EntityFieldFactory.Create(EmailTemplateFieldIndex.Guid);}
		}
		/// <summary>Creates a new EmailTemplateEntity.PersonGuid field instance</summary>
		public static EntityField PersonGuid
		{
			get { return (EntityField)EntityFieldFactory.Create(EmailTemplateFieldIndex.PersonGuid);}
		}
		/// <summary>Creates a new EmailTemplateEntity.Template field instance</summary>
		public static EntityField Template
		{
			get { return (EntityField)EntityFieldFactory.Create(EmailTemplateFieldIndex.Template);}
		}
	}

	/// <summary>Field Creation Class for entity FeedEntity</summary>
	public partial class FeedFields
	{
		/// <summary>Creates a new FeedEntity.FeedUrl field instance</summary>
		public static EntityField FeedUrl
		{
			get { return (EntityField)EntityFieldFactory.Create(FeedFieldIndex.FeedUrl);}
		}
		/// <summary>Creates a new FeedEntity.Guid field instance</summary>
		public static EntityField Guid
		{
			get { return (EntityField)EntityFieldFactory.Create(FeedFieldIndex.Guid);}
		}
		/// <summary>Creates a new FeedEntity.LastScan field instance</summary>
		public static EntityField LastScan
		{
			get { return (EntityField)EntityFieldFactory.Create(FeedFieldIndex.LastScan);}
		}
		/// <summary>Creates a new FeedEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(FeedFieldIndex.Name);}
		}
		/// <summary>Creates a new FeedEntity.PersonGuid field instance</summary>
		public static EntityField PersonGuid
		{
			get { return (EntityField)EntityFieldFactory.Create(FeedFieldIndex.PersonGuid);}
		}
	}

	/// <summary>Field Creation Class for entity PersonEntity</summary>
	public partial class PersonFields
	{
		/// <summary>Creates a new PersonEntity.Email field instance</summary>
		public static EntityField Email
		{
			get { return (EntityField)EntityFieldFactory.Create(PersonFieldIndex.Email);}
		}
		/// <summary>Creates a new PersonEntity.Firstname field instance</summary>
		public static EntityField Firstname
		{
			get { return (EntityField)EntityFieldFactory.Create(PersonFieldIndex.Firstname);}
		}
		/// <summary>Creates a new PersonEntity.Guid field instance</summary>
		public static EntityField Guid
		{
			get { return (EntityField)EntityFieldFactory.Create(PersonFieldIndex.Guid);}
		}
		/// <summary>Creates a new PersonEntity.Lastname field instance</summary>
		public static EntityField Lastname
		{
			get { return (EntityField)EntityFieldFactory.Create(PersonFieldIndex.Lastname);}
		}
		/// <summary>Creates a new PersonEntity.Password field instance</summary>
		public static EntityField Password
		{
			get { return (EntityField)EntityFieldFactory.Create(PersonFieldIndex.Password);}
		}
		/// <summary>Creates a new PersonEntity.Username field instance</summary>
		public static EntityField Username
		{
			get { return (EntityField)EntityFieldFactory.Create(PersonFieldIndex.Username);}
		}
	}

	/// <summary>Field Creation Class for entity ResponseEntity</summary>
	public partial class ResponseFields
	{
		/// <summary>Creates a new ResponseEntity.EmailTemplateGuid field instance</summary>
		public static EntityField EmailTemplateGuid
		{
			get { return (EntityField)EntityFieldFactory.Create(ResponseFieldIndex.EmailTemplateGuid);}
		}
		/// <summary>Creates a new ResponseEntity.FeedGuid field instance</summary>
		public static EntityField FeedGuid
		{
			get { return (EntityField)EntityFieldFactory.Create(ResponseFieldIndex.FeedGuid);}
		}
		/// <summary>Creates a new ResponseEntity.Guid field instance</summary>
		public static EntityField Guid
		{
			get { return (EntityField)EntityFieldFactory.Create(ResponseFieldIndex.Guid);}
		}
		/// <summary>Creates a new ResponseEntity.Id field instance</summary>
		public static EntityField Id
		{
			get { return (EntityField)EntityFieldFactory.Create(ResponseFieldIndex.Id);}
		}
		/// <summary>Creates a new ResponseEntity.SentOn field instance</summary>
		public static EntityField SentOn
		{
			get { return (EntityField)EntityFieldFactory.Create(ResponseFieldIndex.SentOn);}
		}
		/// <summary>Creates a new ResponseEntity.ToEmail field instance</summary>
		public static EntityField ToEmail
		{
			get { return (EntityField)EntityFieldFactory.Create(ResponseFieldIndex.ToEmail);}
		}
	}
	

}