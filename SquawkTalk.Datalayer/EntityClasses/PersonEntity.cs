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
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using SquawkTalk.Datalayer;
using SquawkTalk.Datalayer.FactoryClasses;
using SquawkTalk.Datalayer.DaoClasses;
using SquawkTalk.Datalayer.RelationClasses;
using SquawkTalk.Datalayer.HelperClasses;
using SquawkTalk.Datalayer.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SquawkTalk.Datalayer.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Person'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class PersonEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection	_emailTemplates;
		private bool	_alwaysFetchEmailTemplates, _alreadyFetchedEmailTemplates;
		private SquawkTalk.Datalayer.CollectionClasses.FeedCollection	_feeds;
		private bool	_alwaysFetchFeeds, _alreadyFetchedFeeds;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name EmailTemplates</summary>
			public static readonly string EmailTemplates = "EmailTemplates";
			/// <summary>Member name Feeds</summary>
			public static readonly string Feeds = "Feeds";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PersonEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public PersonEntity() :base("PersonEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		public PersonEntity(System.Guid guid):base("PersonEntity")
		{
			InitClassFetch(guid, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PersonEntity(System.Guid guid, IPrefetchPath prefetchPathToUse):base("PersonEntity")
		{
			InitClassFetch(guid, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="validator">The custom validator object for this PersonEntity</param>
		public PersonEntity(System.Guid guid, IValidator validator):base("PersonEntity")
		{
			InitClassFetch(guid, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_emailTemplates = (SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection)info.GetValue("_emailTemplates", typeof(SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection));
			_alwaysFetchEmailTemplates = info.GetBoolean("_alwaysFetchEmailTemplates");
			_alreadyFetchedEmailTemplates = info.GetBoolean("_alreadyFetchedEmailTemplates");

			_feeds = (SquawkTalk.Datalayer.CollectionClasses.FeedCollection)info.GetValue("_feeds", typeof(SquawkTalk.Datalayer.CollectionClasses.FeedCollection));
			_alwaysFetchFeeds = info.GetBoolean("_alwaysFetchFeeds");
			_alreadyFetchedFeeds = info.GetBoolean("_alreadyFetchedFeeds");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmailTemplates = (_emailTemplates.Count > 0);
			_alreadyFetchedFeeds = (_feeds.Count > 0);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "EmailTemplates":
					toReturn.Add(Relations.EmailTemplateEntityUsingPersonGuid);
					break;
				case "Feeds":
					toReturn.Add(Relations.FeedEntityUsingPersonGuid);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_emailTemplates", (!this.MarkedForDeletion?_emailTemplates:null));
			info.AddValue("_alwaysFetchEmailTemplates", _alwaysFetchEmailTemplates);
			info.AddValue("_alreadyFetchedEmailTemplates", _alreadyFetchedEmailTemplates);
			info.AddValue("_feeds", (!this.MarkedForDeletion?_feeds:null));
			info.AddValue("_alwaysFetchFeeds", _alwaysFetchFeeds);
			info.AddValue("_alreadyFetchedFeeds", _alreadyFetchedFeeds);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "EmailTemplates":
					_alreadyFetchedEmailTemplates = true;
					if(entity!=null)
					{
						this.EmailTemplates.Add((EmailTemplateEntity)entity);
					}
					break;
				case "Feeds":
					_alreadyFetchedFeeds = true;
					if(entity!=null)
					{
						this.Feeds.Add((FeedEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "EmailTemplates":
					_emailTemplates.Add((EmailTemplateEntity)relatedEntity);
					break;
				case "Feeds":
					_feeds.Add((FeedEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "EmailTemplates":
					this.PerformRelatedEntityRemoval(_emailTemplates, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Feeds":
					this.PerformRelatedEntityRemoval(_feeds, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_emailTemplates);
			toReturn.Add(_feeds);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid)
		{
			return FetchUsingPK(guid, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(guid, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(guid, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(guid, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Guid, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PersonRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'EmailTemplateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmailTemplateEntity'</returns>
		public SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection GetMultiEmailTemplates(bool forceFetch)
		{
			return GetMultiEmailTemplates(forceFetch, _emailTemplates.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmailTemplateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmailTemplateEntity'</returns>
		public SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection GetMultiEmailTemplates(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmailTemplates(forceFetch, _emailTemplates.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmailTemplateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection GetMultiEmailTemplates(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmailTemplates(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmailTemplateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection GetMultiEmailTemplates(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmailTemplates || forceFetch || _alwaysFetchEmailTemplates) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_emailTemplates);
				_emailTemplates.SuppressClearInGetMulti=!forceFetch;
				_emailTemplates.EntityFactoryToUse = entityFactoryToUse;
				_emailTemplates.GetMultiManyToOne(this, filter);
				_emailTemplates.SuppressClearInGetMulti=false;
				_alreadyFetchedEmailTemplates = true;
			}
			return _emailTemplates;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmailTemplates'. These settings will be taken into account
		/// when the property EmailTemplates is requested or GetMultiEmailTemplates is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmailTemplates(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_emailTemplates.SortClauses=sortClauses;
			_emailTemplates.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'FeedEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'FeedEntity'</returns>
		public SquawkTalk.Datalayer.CollectionClasses.FeedCollection GetMultiFeeds(bool forceFetch)
		{
			return GetMultiFeeds(forceFetch, _feeds.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'FeedEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'FeedEntity'</returns>
		public SquawkTalk.Datalayer.CollectionClasses.FeedCollection GetMultiFeeds(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiFeeds(forceFetch, _feeds.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'FeedEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SquawkTalk.Datalayer.CollectionClasses.FeedCollection GetMultiFeeds(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiFeeds(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'FeedEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SquawkTalk.Datalayer.CollectionClasses.FeedCollection GetMultiFeeds(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedFeeds || forceFetch || _alwaysFetchFeeds) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_feeds);
				_feeds.SuppressClearInGetMulti=!forceFetch;
				_feeds.EntityFactoryToUse = entityFactoryToUse;
				_feeds.GetMultiManyToOne(this, filter);
				_feeds.SuppressClearInGetMulti=false;
				_alreadyFetchedFeeds = true;
			}
			return _feeds;
		}

		/// <summary> Sets the collection parameters for the collection for 'Feeds'. These settings will be taken into account
		/// when the property Feeds is requested or GetMultiFeeds is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersFeeds(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_feeds.SortClauses=sortClauses;
			_feeds.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("EmailTemplates", _emailTemplates);
			toReturn.Add("Feeds", _feeds);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="validator">The validator object for this PersonEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Guid guid, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(guid, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_emailTemplates = new SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection();
			_emailTemplates.SetContainingEntityInfo(this, "Person");

			_feeds = new SquawkTalk.Datalayer.CollectionClasses.FeedCollection();
			_feeds.SetContainingEntityInfo(this, "Person");
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Email", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Firstname", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Guid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Lastname", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Username", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="guid">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Guid guid, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)PersonFieldIndex.Guid].ForcedCurrentValueWrite(guid);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreatePersonDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new PersonEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static PersonRelations Relations
		{
			get	{ return new PersonRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmailTemplate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmailTemplates
		{
			get { return new PrefetchPathElement(new SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection(), (IEntityRelation)GetRelationsForField("EmailTemplates")[0], (int)SquawkTalk.Datalayer.EntityType.PersonEntity, (int)SquawkTalk.Datalayer.EntityType.EmailTemplateEntity, 0, null, null, null, "EmailTemplates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Feed' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathFeeds
		{
			get { return new PrefetchPathElement(new SquawkTalk.Datalayer.CollectionClasses.FeedCollection(), (IEntityRelation)GetRelationsForField("Feeds")[0], (int)SquawkTalk.Datalayer.EntityType.PersonEntity, (int)SquawkTalk.Datalayer.EntityType.FeedEntity, 0, null, null, null, "Feeds", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Email property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Email
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Email, true); }
			set	{ SetValue((int)PersonFieldIndex.Email, value, true); }
		}

		/// <summary> The Firstname property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Firstname"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Firstname
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Firstname, true); }
			set	{ SetValue((int)PersonFieldIndex.Firstname, value, true); }
		}

		/// <summary> The Guid property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Guid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Guid
		{
			get { return (System.Guid)GetValue((int)PersonFieldIndex.Guid, true); }
			set	{ SetValue((int)PersonFieldIndex.Guid, value, true); }
		}

		/// <summary> The Lastname property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Lastname"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Lastname
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Lastname, true); }
			set	{ SetValue((int)PersonFieldIndex.Lastname, value, true); }
		}

		/// <summary> The Password property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Password
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Password, true); }
			set	{ SetValue((int)PersonFieldIndex.Password, value, true); }
		}

		/// <summary> The Username property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Username, true); }
			set	{ SetValue((int)PersonFieldIndex.Username, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmailTemplateEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmailTemplates()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SquawkTalk.Datalayer.CollectionClasses.EmailTemplateCollection EmailTemplates
		{
			get	{ return GetMultiEmailTemplates(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmailTemplates. When set to true, EmailTemplates is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmailTemplates is accessed. You can always execute/ a forced fetch by calling GetMultiEmailTemplates(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmailTemplates
		{
			get	{ return _alwaysFetchEmailTemplates; }
			set	{ _alwaysFetchEmailTemplates = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmailTemplates already has been fetched. Setting this property to false when EmailTemplates has been fetched
		/// will clear the EmailTemplates collection well. Setting this property to true while EmailTemplates hasn't been fetched disables lazy loading for EmailTemplates</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmailTemplates
		{
			get { return _alreadyFetchedEmailTemplates;}
			set 
			{
				if(_alreadyFetchedEmailTemplates && !value && (_emailTemplates != null))
				{
					_emailTemplates.Clear();
				}
				_alreadyFetchedEmailTemplates = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'FeedEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFeeds()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SquawkTalk.Datalayer.CollectionClasses.FeedCollection Feeds
		{
			get	{ return GetMultiFeeds(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Feeds. When set to true, Feeds is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Feeds is accessed. You can always execute/ a forced fetch by calling GetMultiFeeds(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchFeeds
		{
			get	{ return _alwaysFetchFeeds; }
			set	{ _alwaysFetchFeeds = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Feeds already has been fetched. Setting this property to false when Feeds has been fetched
		/// will clear the Feeds collection well. Setting this property to true while Feeds hasn't been fetched disables lazy loading for Feeds</summary>
		[Browsable(false)]
		public bool AlreadyFetchedFeeds
		{
			get { return _alreadyFetchedFeeds;}
			set 
			{
				if(_alreadyFetchedFeeds && !value && (_feeds != null))
				{
					_feeds.Clear();
				}
				_alreadyFetchedFeeds = value;
			}
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the SquawkTalk.Datalayer.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SquawkTalk.Datalayer.EntityType.PersonEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
