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

	/// <summary>Entity class which represents the entity 'Feed'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class FeedEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SquawkTalk.Datalayer.CollectionClasses.ResponseCollection	_responses;
		private bool	_alwaysFetchResponses, _alreadyFetchedResponses;
		private PersonEntity _person;
		private bool	_alwaysFetchPerson, _alreadyFetchedPerson, _personReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name Responses</summary>
			public static readonly string Responses = "Responses";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static FeedEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public FeedEntity() :base("FeedEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		public FeedEntity(System.Guid guid):base("FeedEntity")
		{
			InitClassFetch(guid, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public FeedEntity(System.Guid guid, IPrefetchPath prefetchPathToUse):base("FeedEntity")
		{
			InitClassFetch(guid, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		/// <param name="validator">The custom validator object for this FeedEntity</param>
		public FeedEntity(System.Guid guid, IValidator validator):base("FeedEntity")
		{
			InitClassFetch(guid, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected FeedEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_responses = (SquawkTalk.Datalayer.CollectionClasses.ResponseCollection)info.GetValue("_responses", typeof(SquawkTalk.Datalayer.CollectionClasses.ResponseCollection));
			_alwaysFetchResponses = info.GetBoolean("_alwaysFetchResponses");
			_alreadyFetchedResponses = info.GetBoolean("_alreadyFetchedResponses");
			_person = (PersonEntity)info.GetValue("_person", typeof(PersonEntity));
			if(_person!=null)
			{
				_person.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_personReturnsNewIfNotFound = info.GetBoolean("_personReturnsNewIfNotFound");
			_alwaysFetchPerson = info.GetBoolean("_alwaysFetchPerson");
			_alreadyFetchedPerson = info.GetBoolean("_alreadyFetchedPerson");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((FeedFieldIndex)fieldIndex)
			{
				case FeedFieldIndex.PersonGuid:
					DesetupSyncPerson(true, false);
					_alreadyFetchedPerson = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedResponses = (_responses.Count > 0);
			_alreadyFetchedPerson = (_person != null);
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
				case "Person":
					toReturn.Add(Relations.PersonEntityUsingPersonGuid);
					break;
				case "Responses":
					toReturn.Add(Relations.ResponseEntityUsingFeedGuid);
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
			info.AddValue("_responses", (!this.MarkedForDeletion?_responses:null));
			info.AddValue("_alwaysFetchResponses", _alwaysFetchResponses);
			info.AddValue("_alreadyFetchedResponses", _alreadyFetchedResponses);
			info.AddValue("_person", (!this.MarkedForDeletion?_person:null));
			info.AddValue("_personReturnsNewIfNotFound", _personReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchPerson", _alwaysFetchPerson);
			info.AddValue("_alreadyFetchedPerson", _alreadyFetchedPerson);

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
				case "Person":
					_alreadyFetchedPerson = true;
					this.Person = (PersonEntity)entity;
					break;
				case "Responses":
					_alreadyFetchedResponses = true;
					if(entity!=null)
					{
						this.Responses.Add((ResponseEntity)entity);
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
				case "Person":
					SetupSyncPerson(relatedEntity);
					break;
				case "Responses":
					_responses.Add((ResponseEntity)relatedEntity);
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
				case "Person":
					DesetupSyncPerson(false, true);
					break;
				case "Responses":
					this.PerformRelatedEntityRemoval(_responses, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_person!=null)
			{
				toReturn.Add(_person);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_responses);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid)
		{
			return FetchUsingPK(guid, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(guid, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(guid, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
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
			return new FeedRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ResponseEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ResponseEntity'</returns>
		public SquawkTalk.Datalayer.CollectionClasses.ResponseCollection GetMultiResponses(bool forceFetch)
		{
			return GetMultiResponses(forceFetch, _responses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ResponseEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ResponseEntity'</returns>
		public SquawkTalk.Datalayer.CollectionClasses.ResponseCollection GetMultiResponses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiResponses(forceFetch, _responses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ResponseEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public SquawkTalk.Datalayer.CollectionClasses.ResponseCollection GetMultiResponses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiResponses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ResponseEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SquawkTalk.Datalayer.CollectionClasses.ResponseCollection GetMultiResponses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedResponses || forceFetch || _alwaysFetchResponses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_responses);
				_responses.SuppressClearInGetMulti=!forceFetch;
				_responses.EntityFactoryToUse = entityFactoryToUse;
				_responses.GetMultiManyToOne(this, filter);
				_responses.SuppressClearInGetMulti=false;
				_alreadyFetchedResponses = true;
			}
			return _responses;
		}

		/// <summary> Sets the collection parameters for the collection for 'Responses'. These settings will be taken into account
		/// when the property Responses is requested or GetMultiResponses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersResponses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_responses.SortClauses=sortClauses;
			_responses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'PersonEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'PersonEntity' which is related to this entity.</returns>
		public PersonEntity GetSinglePerson()
		{
			return GetSinglePerson(false);
		}

		/// <summary> Retrieves the related entity of type 'PersonEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'PersonEntity' which is related to this entity.</returns>
		public virtual PersonEntity GetSinglePerson(bool forceFetch)
		{
			if( ( !_alreadyFetchedPerson || forceFetch || _alwaysFetchPerson) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.PersonEntityUsingPersonGuid);
				PersonEntity newEntity = new PersonEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.PersonGuid);
				}
				if(fetchResult)
				{
					newEntity = (PersonEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_personReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Person = newEntity;
				_alreadyFetchedPerson = fetchResult;
			}
			return _person;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Person", _person);
			toReturn.Add("Responses", _responses);
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
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
		/// <param name="validator">The validator object for this FeedEntity</param>
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

			_responses = new SquawkTalk.Datalayer.CollectionClasses.ResponseCollection();
			_responses.SetContainingEntityInfo(this, "Feed");
			_personReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FeedUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Guid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastScan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PersonGuid", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _person</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", SquawkTalk.Datalayer.RelationClasses.StaticFeedRelations.PersonEntityUsingPersonGuidStatic, true, signalRelatedEntity, "Feeds", resetFKFields, new int[] { (int)FeedFieldIndex.PersonGuid } );		
			_person = null;
		}
		
		/// <summary> setups the sync logic for member _person</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPerson(IEntityCore relatedEntity)
		{
			if(_person!=relatedEntity)
			{		
				DesetupSyncPerson(true, true);
				_person = (PersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", SquawkTalk.Datalayer.RelationClasses.StaticFeedRelations.PersonEntityUsingPersonGuidStatic, true, ref _alreadyFetchedPerson, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="guid">PK value for Feed which data should be fetched into this Feed object</param>
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
				this.Fields[(int)FeedFieldIndex.Guid].ForcedCurrentValueWrite(guid);
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
			return DAOFactory.CreateFeedDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new FeedEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static FeedRelations Relations
		{
			get	{ return new FeedRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Response' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathResponses
		{
			get { return new PrefetchPathElement(new SquawkTalk.Datalayer.CollectionClasses.ResponseCollection(), (IEntityRelation)GetRelationsForField("Responses")[0], (int)SquawkTalk.Datalayer.EntityType.FeedEntity, (int)SquawkTalk.Datalayer.EntityType.ResponseEntity, 0, null, null, null, "Responses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Person'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPerson
		{
			get	{ return new PrefetchPathElement(new SquawkTalk.Datalayer.CollectionClasses.PersonCollection(), (IEntityRelation)GetRelationsForField("Person")[0], (int)SquawkTalk.Datalayer.EntityType.FeedEntity, (int)SquawkTalk.Datalayer.EntityType.PersonEntity, 0, null, null, null, "Person", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FeedUrl property of the Entity Feed<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Feed"."FeedUrl"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String FeedUrl
		{
			get { return (System.String)GetValue((int)FeedFieldIndex.FeedUrl, true); }
			set	{ SetValue((int)FeedFieldIndex.FeedUrl, value, true); }
		}

		/// <summary> The Guid property of the Entity Feed<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Feed"."Guid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Guid
		{
			get { return (System.Guid)GetValue((int)FeedFieldIndex.Guid, true); }
			set	{ SetValue((int)FeedFieldIndex.Guid, value, true); }
		}

		/// <summary> The LastScan property of the Entity Feed<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Feed"."LastScan"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> LastScan
		{
			get { return (Nullable<System.DateTime>)GetValue((int)FeedFieldIndex.LastScan, false); }
			set	{ SetValue((int)FeedFieldIndex.LastScan, value, true); }
		}

		/// <summary> The Name property of the Entity Feed<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Feed"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)FeedFieldIndex.Name, true); }
			set	{ SetValue((int)FeedFieldIndex.Name, value, true); }
		}

		/// <summary> The PersonGuid property of the Entity Feed<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Feed"."PersonGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid PersonGuid
		{
			get { return (System.Guid)GetValue((int)FeedFieldIndex.PersonGuid, true); }
			set	{ SetValue((int)FeedFieldIndex.PersonGuid, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ResponseEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiResponses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual SquawkTalk.Datalayer.CollectionClasses.ResponseCollection Responses
		{
			get	{ return GetMultiResponses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Responses. When set to true, Responses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Responses is accessed. You can always execute/ a forced fetch by calling GetMultiResponses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchResponses
		{
			get	{ return _alwaysFetchResponses; }
			set	{ _alwaysFetchResponses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Responses already has been fetched. Setting this property to false when Responses has been fetched
		/// will clear the Responses collection well. Setting this property to true while Responses hasn't been fetched disables lazy loading for Responses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedResponses
		{
			get { return _alreadyFetchedResponses;}
			set 
			{
				if(_alreadyFetchedResponses && !value && (_responses != null))
				{
					_responses.Clear();
				}
				_alreadyFetchedResponses = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'PersonEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get	{ return GetSinglePerson(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncPerson(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Feeds", "Person", _person, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Person. When set to true, Person is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Person is accessed. You can always execute a forced fetch by calling GetSinglePerson(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPerson
		{
			get	{ return _alwaysFetchPerson; }
			set	{ _alwaysFetchPerson = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Person already has been fetched. Setting this property to false when Person has been fetched
		/// will set Person to null as well. Setting this property to true while Person hasn't been fetched disables lazy loading for Person</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPerson
		{
			get { return _alreadyFetchedPerson;}
			set 
			{
				if(_alreadyFetchedPerson && !value)
				{
					this.Person = null;
				}
				_alreadyFetchedPerson = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Person is not found
		/// in the database. When set to true, Person will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool PersonReturnsNewIfNotFound
		{
			get	{ return _personReturnsNewIfNotFound; }
			set { _personReturnsNewIfNotFound = value; }	
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
			get { return (int)SquawkTalk.Datalayer.EntityType.FeedEntity; }
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
