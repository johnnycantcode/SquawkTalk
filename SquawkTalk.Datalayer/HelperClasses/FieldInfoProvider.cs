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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SquawkTalk.Datalayer.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (4 + 0));
			InitEmailTemplateEntityInfos();
			InitFeedEntityInfos();
			InitPersonEntityInfos();
			InitResponseEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits EmailTemplateEntity's FieldInfo objects</summary>
		private void InitEmailTemplateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmailTemplateFieldIndex), "EmailTemplateEntity");
			this.AddElementFieldInfo("EmailTemplateEntity", "Guid", typeof(System.Guid), true, false, false, false,  (int)EmailTemplateFieldIndex.Guid, 0, 0, 0);
			this.AddElementFieldInfo("EmailTemplateEntity", "PersonGuid", typeof(System.Guid), false, true, false, false,  (int)EmailTemplateFieldIndex.PersonGuid, 0, 0, 0);
			this.AddElementFieldInfo("EmailTemplateEntity", "Template", typeof(System.String), false, false, false, true,  (int)EmailTemplateFieldIndex.Template, 2147483647, 0, 0);
		}
		/// <summary>Inits FeedEntity's FieldInfo objects</summary>
		private void InitFeedEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(FeedFieldIndex), "FeedEntity");
			this.AddElementFieldInfo("FeedEntity", "FeedUrl", typeof(System.String), false, false, false, true,  (int)FeedFieldIndex.FeedUrl, 500, 0, 0);
			this.AddElementFieldInfo("FeedEntity", "Guid", typeof(System.Guid), true, false, false, false,  (int)FeedFieldIndex.Guid, 0, 0, 0);
			this.AddElementFieldInfo("FeedEntity", "LastScan", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)FeedFieldIndex.LastScan, 0, 0, 0);
			this.AddElementFieldInfo("FeedEntity", "Name", typeof(System.String), false, false, false, true,  (int)FeedFieldIndex.Name, 100, 0, 0);
			this.AddElementFieldInfo("FeedEntity", "PersonGuid", typeof(System.Guid), false, true, false, false,  (int)FeedFieldIndex.PersonGuid, 0, 0, 0);
		}
		/// <summary>Inits PersonEntity's FieldInfo objects</summary>
		private void InitPersonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PersonFieldIndex), "PersonEntity");
			this.AddElementFieldInfo("PersonEntity", "Email", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.Email, 100, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Firstname", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Firstname, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Guid", typeof(System.Guid), true, false, false, false,  (int)PersonFieldIndex.Guid, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Lastname", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Lastname, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Password", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.Password, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Username", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.Username, 50, 0, 0);
		}
		/// <summary>Inits ResponseEntity's FieldInfo objects</summary>
		private void InitResponseEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ResponseFieldIndex), "ResponseEntity");
			this.AddElementFieldInfo("ResponseEntity", "EmailTemplateGuid", typeof(System.Guid), false, false, false, false,  (int)ResponseFieldIndex.EmailTemplateGuid, 0, 0, 0);
			this.AddElementFieldInfo("ResponseEntity", "FeedGuid", typeof(System.Guid), false, true, false, false,  (int)ResponseFieldIndex.FeedGuid, 0, 0, 0);
			this.AddElementFieldInfo("ResponseEntity", "Guid", typeof(System.Guid), true, false, false, false,  (int)ResponseFieldIndex.Guid, 0, 0, 0);
			this.AddElementFieldInfo("ResponseEntity", "Id", typeof(System.String), false, false, false, false,  (int)ResponseFieldIndex.Id, 2147483647, 0, 0);
			this.AddElementFieldInfo("ResponseEntity", "SentOn", typeof(System.DateTime), false, false, false, false,  (int)ResponseFieldIndex.SentOn, 0, 0, 0);
			this.AddElementFieldInfo("ResponseEntity", "ToEmail", typeof(System.String), false, false, false, false,  (int)ResponseFieldIndex.ToEmail, 500, 0, 0);
		}
		
	}
}




