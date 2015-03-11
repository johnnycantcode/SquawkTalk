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
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SquawkTalk.Datalayer.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((4 + 0));
			InitEmailTemplateEntityMappings();
			InitFeedEntityMappings();
			InitPersonEntityMappings();
			InitResponseEntityMappings();

		}


		/// <summary>Inits EmailTemplateEntity's mappings</summary>
		private void InitEmailTemplateEntityMappings()
		{
			this.AddElementMapping( "EmailTemplateEntity", @"SquawkTalk", @"dbo", "EmailTemplate", 3 );
			this.AddElementFieldMapping( "EmailTemplateEntity", "Guid", "Guid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "EmailTemplateEntity", "PersonGuid", "PersonGuid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "EmailTemplateEntity", "Template", "Template", true, "Text", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits FeedEntity's mappings</summary>
		private void InitFeedEntityMappings()
		{
			this.AddElementMapping( "FeedEntity", @"SquawkTalk", @"dbo", "Feed", 5 );
			this.AddElementFieldMapping( "FeedEntity", "FeedUrl", "FeedUrl", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "FeedEntity", "Guid", "Guid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "FeedEntity", "LastScan", "LastScan", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "FeedEntity", "Name", "Name", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "FeedEntity", "PersonGuid", "PersonGuid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 4 );
		}
		/// <summary>Inits PersonEntity's mappings</summary>
		private void InitPersonEntityMappings()
		{
			this.AddElementMapping( "PersonEntity", @"SquawkTalk", @"dbo", "Person", 6 );
			this.AddElementFieldMapping( "PersonEntity", "Email", "Email", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "PersonEntity", "Firstname", "Firstname", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "PersonEntity", "Guid", "Guid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "PersonEntity", "Lastname", "Lastname", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PersonEntity", "Password", "Password", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "PersonEntity", "Username", "Username", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits ResponseEntity's mappings</summary>
		private void InitResponseEntityMappings()
		{
			this.AddElementMapping( "ResponseEntity", @"SquawkTalk", @"dbo", "Response", 6 );
			this.AddElementFieldMapping( "ResponseEntity", "EmailTemplateGuid", "EmailTemplateGuid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 0 );
			this.AddElementFieldMapping( "ResponseEntity", "FeedGuid", "FeedGuid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			this.AddElementFieldMapping( "ResponseEntity", "Guid", "Guid", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2 );
			this.AddElementFieldMapping( "ResponseEntity", "Id", "Id", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ResponseEntity", "SentOn", "SentOn", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "ResponseEntity", "ToEmail", "ToEmail", false, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 5 );
		}

	}
}