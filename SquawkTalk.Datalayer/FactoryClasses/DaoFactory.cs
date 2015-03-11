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

using SquawkTalk.Datalayer.DaoClasses;
using SquawkTalk.Datalayer.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SquawkTalk.Datalayer.FactoryClasses
{
	/// <summary>
	/// Generic factory for DAO objects. 
	/// </summary>
	public partial class DAOFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private DAOFactory()
		{
		}

		/// <summary>Creates a new EmailTemplateDAO object</summary>
		/// <returns>the new DAO object ready to use for EmailTemplate Entities</returns>
		public static EmailTemplateDAO CreateEmailTemplateDAO()
		{
			return new EmailTemplateDAO();
		}

		/// <summary>Creates a new FeedDAO object</summary>
		/// <returns>the new DAO object ready to use for Feed Entities</returns>
		public static FeedDAO CreateFeedDAO()
		{
			return new FeedDAO();
		}

		/// <summary>Creates a new PersonDAO object</summary>
		/// <returns>the new DAO object ready to use for Person Entities</returns>
		public static PersonDAO CreatePersonDAO()
		{
			return new PersonDAO();
		}

		/// <summary>Creates a new ResponseDAO object</summary>
		/// <returns>the new DAO object ready to use for Response Entities</returns>
		public static ResponseDAO CreateResponseDAO()
		{
			return new ResponseDAO();
		}

		/// <summary>Creates a new TypedListDAO object</summary>
		/// <returns>The new DAO object ready to use for Typed Lists</returns>
		public static TypedListDAO CreateTypedListDAO()
		{
			return new TypedListDAO();
		}

		#region Included Code

		#endregion
	}
}
