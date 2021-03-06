﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Entity class which represents the entity 'Response'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ResponseEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private FeedEntity _feed;
		private bool	_alwaysFetchFeed, _alreadyFetchedFeed, _feedReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Feed</summary>
			public static readonly string Feed = "Feed";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ResponseEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ResponseEntity() :base("ResponseEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		public ResponseEntity(System.Guid guid):base("ResponseEntity")
		{
			InitClassFetch(guid, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ResponseEntity(System.Guid guid, IPrefetchPath prefetchPathToUse):base("ResponseEntity")
		{
			InitClassFetch(guid, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		/// <param name="validator">The custom validator object for this ResponseEntity</param>
		public ResponseEntity(System.Guid guid, IValidator validator):base("ResponseEntity")
		{
			InitClassFetch(guid, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ResponseEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_feed = (FeedEntity)info.GetValue("_feed", typeof(FeedEntity));
			if(_feed!=null)
			{
				_feed.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_feedReturnsNewIfNotFound = info.GetBoolean("_feedReturnsNewIfNotFound");
			_alwaysFetchFeed = info.GetBoolean("_alwaysFetchFeed");
			_alreadyFetchedFeed = info.GetBoolean("_alreadyFetchedFeed");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ResponseFieldIndex)fieldIndex)
			{
				case ResponseFieldIndex.FeedGuid:
					DesetupSyncFeed(true, false);
					_alreadyFetchedFeed = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedFeed = (_feed != null);
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
				case "Feed":
					toReturn.Add(Relations.FeedEntityUsingFeedGuid);
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
			info.AddValue("_feed", (!this.MarkedForDeletion?_feed:null));
			info.AddValue("_feedReturnsNewIfNotFound", _feedReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchFeed", _alwaysFetchFeed);
			info.AddValue("_alreadyFetchedFeed", _alreadyFetchedFeed);

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
				case "Feed":
					_alreadyFetchedFeed = true;
					this.Feed = (FeedEntity)entity;
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
				case "Feed":
					SetupSyncFeed(relatedEntity);
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
				case "Feed":
					DesetupSyncFeed(false, true);
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
			if(_feed!=null)
			{
				toReturn.Add(_feed);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid)
		{
			return FetchUsingPK(guid, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(guid, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Guid guid, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(guid, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
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
			return new ResponseRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'FeedEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'FeedEntity' which is related to this entity.</returns>
		public FeedEntity GetSingleFeed()
		{
			return GetSingleFeed(false);
		}

		/// <summary> Retrieves the related entity of type 'FeedEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'FeedEntity' which is related to this entity.</returns>
		public virtual FeedEntity GetSingleFeed(bool forceFetch)
		{
			if( ( !_alreadyFetchedFeed || forceFetch || _alwaysFetchFeed) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.FeedEntityUsingFeedGuid);
				FeedEntity newEntity = new FeedEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FeedGuid);
				}
				if(fetchResult)
				{
					newEntity = (FeedEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_feedReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Feed = newEntity;
				_alreadyFetchedFeed = fetchResult;
			}
			return _feed;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Feed", _feed);
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
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
		/// <param name="validator">The validator object for this ResponseEntity</param>
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
			_feedReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("EmailTemplateGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FeedGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Guid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SentOn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ToEmail", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _feed</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncFeed(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _feed, new PropertyChangedEventHandler( OnFeedPropertyChanged ), "Feed", SquawkTalk.Datalayer.RelationClasses.StaticResponseRelations.FeedEntityUsingFeedGuidStatic, true, signalRelatedEntity, "Responses", resetFKFields, new int[] { (int)ResponseFieldIndex.FeedGuid } );		
			_feed = null;
		}
		
		/// <summary> setups the sync logic for member _feed</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncFeed(IEntityCore relatedEntity)
		{
			if(_feed!=relatedEntity)
			{		
				DesetupSyncFeed(true, true);
				_feed = (FeedEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _feed, new PropertyChangedEventHandler( OnFeedPropertyChanged ), "Feed", SquawkTalk.Datalayer.RelationClasses.StaticResponseRelations.FeedEntityUsingFeedGuidStatic, true, ref _alreadyFetchedFeed, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnFeedPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="guid">PK value for Response which data should be fetched into this Response object</param>
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
				this.Fields[(int)ResponseFieldIndex.Guid].ForcedCurrentValueWrite(guid);
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
			return DAOFactory.CreateResponseDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ResponseEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ResponseRelations Relations
		{
			get	{ return new ResponseRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Feed'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathFeed
		{
			get	{ return new PrefetchPathElement(new SquawkTalk.Datalayer.CollectionClasses.FeedCollection(), (IEntityRelation)GetRelationsForField("Feed")[0], (int)SquawkTalk.Datalayer.EntityType.ResponseEntity, (int)SquawkTalk.Datalayer.EntityType.FeedEntity, 0, null, null, null, "Feed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The EmailTemplateGuid property of the Entity Response<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Response"."EmailTemplateGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid EmailTemplateGuid
		{
			get { return (System.Guid)GetValue((int)ResponseFieldIndex.EmailTemplateGuid, true); }
			set	{ SetValue((int)ResponseFieldIndex.EmailTemplateGuid, value, true); }
		}

		/// <summary> The FeedGuid property of the Entity Response<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Response"."FeedGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid FeedGuid
		{
			get { return (System.Guid)GetValue((int)ResponseFieldIndex.FeedGuid, true); }
			set	{ SetValue((int)ResponseFieldIndex.FeedGuid, value, true); }
		}

		/// <summary> The Guid property of the Entity Response<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Response"."Guid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Guid
		{
			get { return (System.Guid)GetValue((int)ResponseFieldIndex.Guid, true); }
			set	{ SetValue((int)ResponseFieldIndex.Guid, value, true); }
		}

		/// <summary> The Id property of the Entity Response<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Response"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Id
		{
			get { return (System.String)GetValue((int)ResponseFieldIndex.Id, true); }
			set	{ SetValue((int)ResponseFieldIndex.Id, value, true); }
		}

		/// <summary> The SentOn property of the Entity Response<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Response"."SentOn"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SentOn
		{
			get { return (System.DateTime)GetValue((int)ResponseFieldIndex.SentOn, true); }
			set	{ SetValue((int)ResponseFieldIndex.SentOn, value, true); }
		}

		/// <summary> The ToEmail property of the Entity Response<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Response"."ToEmail"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ToEmail
		{
			get { return (System.String)GetValue((int)ResponseFieldIndex.ToEmail, true); }
			set	{ SetValue((int)ResponseFieldIndex.ToEmail, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'FeedEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleFeed()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual FeedEntity Feed
		{
			get	{ return GetSingleFeed(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncFeed(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Responses", "Feed", _feed, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Feed. When set to true, Feed is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Feed is accessed. You can always execute a forced fetch by calling GetSingleFeed(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchFeed
		{
			get	{ return _alwaysFetchFeed; }
			set	{ _alwaysFetchFeed = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Feed already has been fetched. Setting this property to false when Feed has been fetched
		/// will set Feed to null as well. Setting this property to true while Feed hasn't been fetched disables lazy loading for Feed</summary>
		[Browsable(false)]
		public bool AlreadyFetchedFeed
		{
			get { return _alreadyFetchedFeed;}
			set 
			{
				if(_alreadyFetchedFeed && !value)
				{
					this.Feed = null;
				}
				_alreadyFetchedFeed = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Feed is not found
		/// in the database. When set to true, Feed will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool FeedReturnsNewIfNotFound
		{
			get	{ return _feedReturnsNewIfNotFound; }
			set { _feedReturnsNewIfNotFound = value; }	
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
			get { return (int)SquawkTalk.Datalayer.EntityType.ResponseEntity; }
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
