// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Autofac.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Rhetos.Extensibility.Interfaces.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Rhetos.Utilities.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Rhetos.Security.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Rhetos.Logging.Interfaces.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\EntityFramework.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\EntityFramework.SqlServer.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Rhetos.Persistence.Interfaces.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Plugins\Rhetos.Processing.DefaultCommands.Interfaces.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Rhetos.Processing.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll
// Reference: d:\Rhetos\RhetosWorkshop\HotelRhetos\dist\HotelRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll
// CompilerOptions: "/optimize"

namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    [DataContract]/*DataStructureInfo ClassAttributes Common.AutoCodeCache*/
    public class AutoCodeCache : EntityBase<Common.AutoCodeCache>/*Next DataStructureInfo ClassInterace Common.AutoCodeCache*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AutoCodeCache ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Entity*/
        public string Entity { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Property*/
        public string Property { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Grouping*/
        public string Grouping { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Prefix*/
        public string Prefix { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.MinDigits*/
        public int? MinDigits { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.LastCode*/
        public int? LastCode { get; set; }
        /*DataStructureInfo ClassBody Common.AutoCodeCache*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.FilterId*/
    public class FilterId : EntityBase<Common.FilterId>, Rhetos.Dom.DefaultConcepts.ICommonFilterId/*Next DataStructureInfo ClassInterace Common.FilterId*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_FilterId ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.FilterId.Handle*/
        public Guid? Handle { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.FilterId.Value*/
        public Guid? Value { get; set; }
        /*DataStructureInfo ClassBody Common.FilterId*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata : EntityBase<Common.KeepSynchronizedMetadata>, Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata/*Next DataStructureInfo ClassInterace Common.KeepSynchronizedMetadata*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_KeepSynchronizedMetadata ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Target*/
        public string Target { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Source*/
        public string Source { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Context*/
        public string Context { get; set; }
        /*DataStructureInfo ClassBody Common.KeepSynchronizedMetadata*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ExclusiveLock*/
    public class ExclusiveLock : EntityBase<Common.ExclusiveLock>/*Next DataStructureInfo ClassInterace Common.ExclusiveLock*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_ExclusiveLock ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockStart*/
        public DateTime? LockStart { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockFinish*/
        public DateTime? LockFinish { get; set; }
        /*DataStructureInfo ClassBody Common.ExclusiveLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SetLock*/
    public class SetLock/*DataStructureInfo ClassInterace Common.SetLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.SetLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ReleaseLock*/
    public class ReleaseLock/*DataStructureInfo ClassInterace Common.ReleaseLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.ReleaseLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogReader*/
    public class LogReader : EntityBase<Common.LogReader>/*Next DataStructureInfo ClassInterace Common.LogReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogReader.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.LogReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader : EntityBase<Common.LogRelatedItemReader>/*Next DataStructureInfo ClassInterace Common.LogRelatedItemReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItemReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.LogID*/
        public Guid? LogID { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItemReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Log*/
    public class Log : EntityBase<Common.Log>/*Next DataStructureInfo ClassInterace Common.Log*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Log ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Log.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.Log*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AddToLog*/
    public class AddToLog/*DataStructureInfo ClassInterace Common.AddToLog*/
    {
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.AddToLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItem*/
    public class LogRelatedItem : EntityBase<Common.LogRelatedItem>/*Next DataStructureInfo ClassInterace Common.LogRelatedItem*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItem ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.Relation*/
        public string Relation { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource : EntityBase<Common.RelatedEventsSource>/*Next DataStructureInfo ClassInterace Common.RelatedEventsSource*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RelatedEventsSource ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToTable*/
        public string RelatedToTable { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToItem*/
        public Guid? RelatedToItem { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.RelatedEventsSource*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Claim*/
    public class Claim : EntityBase<Common.Claim>, Rhetos.Dom.DefaultConcepts.IDeactivatable, Rhetos.Dom.DefaultConcepts.ICommonClaim/*Next DataStructureInfo ClassInterace Common.Claim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Claim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimResource*/
        public string ClaimResource { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimRight*/
        public string ClaimRight { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.Active*/
        public bool? Active { get; set; }
        /*DataStructureInfo ClassBody Common.Claim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.MyClaim*/
    public class MyClaim : EntityBase<Common.MyClaim>/*Next DataStructureInfo ClassInterace Common.MyClaim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_MyClaim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.MyClaim.Applies*/
        public bool? Applies { get; set; }
        /*DataStructureInfo ClassBody Common.MyClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Principal*/
    public class Principal : EntityBase<Common.Principal>, Rhetos.Dom.DefaultConcepts.IPrincipal/*Next DataStructureInfo ClassInterace Common.Principal*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Principal ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Principal.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Principal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole : EntityBase<Common.PrincipalHasRole>, Rhetos.Dom.DefaultConcepts.IPrincipalHasRole/*Next DataStructureInfo ClassInterace Common.PrincipalHasRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalHasRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.RoleID*/
        public Guid? RoleID { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalHasRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Role*/
    public class Role : EntityBase<Common.Role>, Rhetos.Dom.DefaultConcepts.IRole/*Next DataStructureInfo ClassInterace Common.Role*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Role ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Role.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Role*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole : EntityBase<Common.RoleInheritsRole>, Rhetos.Dom.DefaultConcepts.IRoleInheritsRole/*Next DataStructureInfo ClassInterace Common.RoleInheritsRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RoleInheritsRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.UsersFromID*/
        public Guid? UsersFromID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.PermissionsFromID*/
        public Guid? PermissionsFromID { get; set; }
        /*DataStructureInfo ClassBody Common.RoleInheritsRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalPermission*/
    public class PrincipalPermission : EntityBase<Common.PrincipalPermission>, Rhetos.Dom.DefaultConcepts.IPrincipalPermission/*Next DataStructureInfo ClassInterace Common.PrincipalPermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalPermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalPermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RolePermission*/
    public class RolePermission : EntityBase<Common.RolePermission>, Rhetos.Dom.DefaultConcepts.IRolePermission/*Next DataStructureInfo ClassInterace Common.RolePermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RolePermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RolePermission.RoleID*/
        public Guid? RoleID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.RolePermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsReadItems*/
    public class RowPermissionsReadItems/*DataStructureInfo ClassInterace Common.RowPermissionsReadItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsReadItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsWriteItems*/
    public class RowPermissionsWriteItems/*DataStructureInfo ClassInterace Common.RowPermissionsWriteItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsWriteItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredActive*/
    public class SystemRequiredActive/*DataStructureInfo ClassInterace Common.SystemRequiredActive*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredActive*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredLog*/
    public class SystemRequiredLog/*DataStructureInfo ClassInterace Common.SystemRequiredLog*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredPrincipal*/
    public class SystemRequiredPrincipal/*DataStructureInfo ClassInterace Common.SystemRequiredPrincipal*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredPrincipal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredUsersFrom*/
    public class SystemRequiredUsersFrom/*DataStructureInfo ClassInterace Common.SystemRequiredUsersFrom*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredUsersFrom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredClaim*/
    public class SystemRequiredClaim/*DataStructureInfo ClassInterace Common.SystemRequiredClaim*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredRole*/
    public class SystemRequiredRole/*DataStructureInfo ClassInterace Common.SystemRequiredRole*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredRole*/
    }

    /*ModuleInfo Body Common*/
}

namespace HotelRhetos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using HotelRhetos*/

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Hotel*/
    public class Hotel : EntityBase<HotelRhetos.Hotel>/*Next DataStructureInfo ClassInterace HotelRhetos.Hotel*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_Hotel ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_Hotel
            {
                ID = item.ID,
                Name = item.Name,
                Address = item.Address/*DataStructureInfo AssignSimpleProperty HotelRhetos.Hotel*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.Hotel.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Hotel.Address*/
        public string Address { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.Hotel*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Room*/
    public class Room : EntityBase<HotelRhetos.Room>/*Next DataStructureInfo ClassInterace HotelRhetos.Room*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_Room ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_Room
            {
                ID = item.ID,
                Name = item.Name,
                Description = item.Description,
                HotelID = item.HotelID,
                RoomTypeID = item.RoomTypeID,
                CreatedAt = item.CreatedAt/*DataStructureInfo AssignSimpleProperty HotelRhetos.Room*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.Room.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Room.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Room.HotelID*/
        public Guid? HotelID { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Room.RoomTypeID*/
        public Guid? RoomTypeID { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Room.CreatedAt*/
        public DateTime? CreatedAt { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.Room*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.RoomType*/
    public class RoomType : EntityBase<HotelRhetos.RoomType>/*Next DataStructureInfo ClassInterace HotelRhetos.RoomType*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_RoomType ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_RoomType
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price,
                CreatedAt = item.CreatedAt/*DataStructureInfo AssignSimpleProperty HotelRhetos.RoomType*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.RoomType.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.RoomType.Price*/
        public decimal? Price { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.RoomType.CreatedAt*/
        public DateTime? CreatedAt { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.RoomType*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Guest*/
    public class Guest : EntityBase<HotelRhetos.Guest>/*Next DataStructureInfo ClassInterace HotelRhetos.Guest*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_Guest ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_Guest
            {
                ID = item.ID,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty HotelRhetos.Guest*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.Guest.FirstName*/
        public string FirstName { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Guest.LastName*/
        public string LastName { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Guest.PhoneNumber*/
        public string PhoneNumber { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Guest.Email*/
        public string Email { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.Guest*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Service*/
    public class Service : EntityBase<HotelRhetos.Service>/*Next DataStructureInfo ClassInterace HotelRhetos.Service*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_Service ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_Service
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty HotelRhetos.Service*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.Service.Name*/
        public string Name { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Service.Price*/
        public decimal? Price { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.Service*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.ServiceNameContainsDiamond*/
    public class ServiceNameContainsDiamond/*DataStructureInfo ClassInterace HotelRhetos.ServiceNameContainsDiamond*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.ServiceNameContainsDiamond*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.ServiceNameContainsDiamond2*/
    public class ServiceNameContainsDiamond2/*DataStructureInfo ClassInterace HotelRhetos.ServiceNameContainsDiamond2*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.ServiceNameContainsDiamond2*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.ServiceNameContainsWord*/
    public class ServiceNameContainsWord/*DataStructureInfo ClassInterace HotelRhetos.ServiceNameContainsWord*/
    {
        [DataMember]/*PropertyInfo Attribute HotelRhetos.ServiceNameContainsWord.Word*/
        public string Word { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.ServiceNameContainsWord*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Reservations*/
    public class Reservations : EntityBase<HotelRhetos.Reservations>/*Next DataStructureInfo ClassInterace HotelRhetos.Reservations*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_Reservations ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_Reservations
            {
                ID = item.ID,
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
                GuestID = item.GuestID,
                RoomID = item.RoomID/*DataStructureInfo AssignSimpleProperty HotelRhetos.Reservations*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.Reservations.CheckIn*/
        public DateTime? CheckIn { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Reservations.CheckOut*/
        public DateTime? CheckOut { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Reservations.GuestID*/
        public Guid? GuestID { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Reservations.RoomID*/
        public Guid? RoomID { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.Reservations*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Invoice*/
    public class Invoice : EntityBase<HotelRhetos.Invoice>/*Next DataStructureInfo ClassInterace HotelRhetos.Invoice*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_Invoice ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_Invoice
            {
                ID = item.ID,
                TotalAmount = item.TotalAmount,
                Payed = item.Payed,
                ReservationsID = item.ReservationsID/*DataStructureInfo AssignSimpleProperty HotelRhetos.Invoice*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.Invoice.TotalAmount*/
        public decimal? TotalAmount { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Invoice.Payed*/
        public bool? Payed { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.Invoice.ReservationsID*/
        public Guid? ReservationsID { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.Invoice*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.InvoiceItem*/
    public class InvoiceItem : EntityBase<HotelRhetos.InvoiceItem>/*Next DataStructureInfo ClassInterace HotelRhetos.InvoiceItem*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_InvoiceItem ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_InvoiceItem
            {
                ID = item.ID,
                Discount = item.Discount,
                ServiceID = item.ServiceID,
                InvoiceID = item.InvoiceID/*DataStructureInfo AssignSimpleProperty HotelRhetos.InvoiceItem*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.InvoiceItem.Discount*/
        public decimal? Discount { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.InvoiceItem.ServiceID*/
        public Guid? ServiceID { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.InvoiceItem.InvoiceID*/
        public Guid? InvoiceID { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.InvoiceItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.RomNumberOfReservations*/
    public class RomNumberOfReservations : EntityBase<HotelRhetos.RomNumberOfReservations>/*Next DataStructureInfo ClassInterace HotelRhetos.RomNumberOfReservations*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_RomNumberOfReservations ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_RomNumberOfReservations
            {
                ID = item.ID,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty HotelRhetos.RomNumberOfReservations*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.RomNumberOfReservations.NumberOfReservations*/
        public int? NumberOfReservations { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.RomNumberOfReservations*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.RoomGrid*/
    public class RoomGrid : EntityBase<HotelRhetos.RoomGrid>/*Next DataStructureInfo ClassInterace HotelRhetos.RoomGrid*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_RoomGrid ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_RoomGrid
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelName = item.HotelName,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty HotelRhetos.RoomGrid*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.RoomGrid.RoomNumber*/
        public string RoomNumber { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.RoomGrid.HotelName*/
        public string HotelName { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.RoomGrid.NumberOfReservations*/
        public int? NumberOfReservations { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.RoomGrid*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.GeneratedRoom*/
    public class GeneratedRoom/*DataStructureInfo ClassInterace HotelRhetos.GeneratedRoom*/
    {
        [DataMember]/*PropertyInfo Attribute HotelRhetos.GeneratedRoom.NumberOfRooms*/
        public int? NumberOfRooms { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.GeneratedRoom.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.GeneratedRoom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.GeneratedService*/
    public class GeneratedService/*DataStructureInfo ClassInterace HotelRhetos.GeneratedService*/
    {
        [DataMember]/*PropertyInfo Attribute HotelRhetos.GeneratedService.NumberOfServices*/
        public int? NumberOfServices { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.GeneratedService*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.NameServices*/
    public class NameServices : EntityBase<HotelRhetos.NameServices>/*Next DataStructureInfo ClassInterace HotelRhetos.NameServices*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.HotelRhetos_NameServices ToNavigation()
        {
            var item = this;
            return new Common.Queryable.HotelRhetos_NameServices
            {
                ID = item.ID,
                Price = item.Price,
                Price1 = item.Price1/*DataStructureInfo AssignSimpleProperty HotelRhetos.NameServices*/
            };
        }

        [DataMember]/*PropertyInfo Attribute HotelRhetos.NameServices.Price*/
        public decimal? Price { get; set; }
        [DataMember]/*PropertyInfo Attribute HotelRhetos.NameServices.Price1*/
        public decimal? Price1 { get; set; }
        /*DataStructureInfo ClassBody HotelRhetos.NameServices*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.PhoneNumber_RegExMatchFilter*/
    public class PhoneNumber_RegExMatchFilter/*DataStructureInfo ClassInterace HotelRhetos.PhoneNumber_RegExMatchFilter*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.PhoneNumber_RegExMatchFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Email_RegExMatchFilter*/
    public class Email_RegExMatchFilter/*DataStructureInfo ClassInterace HotelRhetos.Email_RegExMatchFilter*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.Email_RegExMatchFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.ServiceNameDiamond*/
    public class ServiceNameDiamond/*DataStructureInfo ClassInterace HotelRhetos.ServiceNameDiamond*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.ServiceNameDiamond*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.LessThan1Use*/
    public class LessThan1Use/*DataStructureInfo ClassInterace HotelRhetos.LessThan1Use*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.LessThan1Use*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.PriceGreaterThan40Dollar*/
    public class PriceGreaterThan40Dollar/*DataStructureInfo ClassInterace HotelRhetos.PriceGreaterThan40Dollar*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.PriceGreaterThan40Dollar*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Name_MaxLengthFilter*/
    public class Name_MaxLengthFilter/*DataStructureInfo ClassInterace HotelRhetos.Name_MaxLengthFilter*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.Name_MaxLengthFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.FirstName_MaxLengthFilter*/
    public class FirstName_MaxLengthFilter/*DataStructureInfo ClassInterace HotelRhetos.FirstName_MaxLengthFilter*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.FirstName_MaxLengthFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.Name_MinLengthFilter*/
    public class Name_MinLengthFilter/*DataStructureInfo ClassInterace HotelRhetos.Name_MinLengthFilter*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.Name_MinLengthFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.FirstName_MinLengthFilter*/
    public class FirstName_MinLengthFilter/*DataStructureInfo ClassInterace HotelRhetos.FirstName_MinLengthFilter*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.FirstName_MinLengthFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes HotelRhetos.SystemRequiredInvoice*/
    public class SystemRequiredInvoice/*DataStructureInfo ClassInterace HotelRhetos.SystemRequiredInvoice*/
    {
        /*DataStructureInfo ClassBody HotelRhetos.SystemRequiredInvoice*/
    }

    /*ModuleInfo Body HotelRhetos*/
}

/*SimpleClasses*/

namespace Common.Queryable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*DataStructureInfo QueryableClassAttributes Common.AutoCodeCache*/
    public class Common_AutoCodeCache : global::Common.AutoCodeCache, IQueryableEntity<Common.AutoCodeCache>, System.IEquatable<Common_AutoCodeCache>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AutoCodeCache*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AutoCodeCache ToSimple()
        {
            var item = this;
            return new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.AutoCodeCache*/

        public bool Equals(Common_AutoCodeCache other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.FilterId*/
    public class Common_FilterId : global::Common.FilterId, IQueryableEntity<Common.FilterId>, System.IEquatable<Common_FilterId>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.FilterId*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.FilterId ToSimple()
        {
            var item = this;
            return new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.FilterId*/

        public bool Equals(Common_FilterId other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.KeepSynchronizedMetadata*/
    public class Common_KeepSynchronizedMetadata : global::Common.KeepSynchronizedMetadata, IQueryableEntity<Common.KeepSynchronizedMetadata>, System.IEquatable<Common_KeepSynchronizedMetadata>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.KeepSynchronizedMetadata*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.KeepSynchronizedMetadata ToSimple()
        {
            var item = this;
            return new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.KeepSynchronizedMetadata*/

        public bool Equals(Common_KeepSynchronizedMetadata other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.ExclusiveLock*/
    public class Common_ExclusiveLock : global::Common.ExclusiveLock, IQueryableEntity<Common.ExclusiveLock>, System.IEquatable<Common_ExclusiveLock>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.ExclusiveLock*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.ExclusiveLock ToSimple()
        {
            var item = this;
            return new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.ExclusiveLock*/

        public bool Equals(Common_ExclusiveLock other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogReader*/
    public class Common_LogReader : global::Common.LogReader, IQueryableEntity<Common.LogReader>, System.IEquatable<Common_LogReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogReader ToSimple()
        {
            var item = this;
            return new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.LogReader*/

        public bool Equals(Common_LogReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItemReader*/
    public class Common_LogRelatedItemReader : global::Common.LogRelatedItemReader, IQueryableEntity<Common.LogRelatedItemReader>, System.IEquatable<Common_LogRelatedItemReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItemReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItemReader ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItemReader.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItemReader.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItemReader.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItemReader*/

        public bool Equals(Common_LogRelatedItemReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Log*/
    public class Common_Log : global::Common.Log, IQueryableEntity<Common.Log>, System.IEquatable<Common_Log>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Log*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Log ToSimple()
        {
            var item = this;
            return new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Log*/

        public bool Equals(Common_Log other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItem*/
    public class Common_LogRelatedItem : global::Common.LogRelatedItem, IQueryableEntity<Common.LogRelatedItem>, System.IEquatable<Common_LogRelatedItem>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItem*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItem ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItem.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItem.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItem.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItem*/

        public bool Equals(Common_LogRelatedItem other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RelatedEventsSource*/
    public class Common_RelatedEventsSource : global::Common.RelatedEventsSource, IQueryableEntity<Common.RelatedEventsSource>, System.IEquatable<Common_RelatedEventsSource>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RelatedEventsSource*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RelatedEventsSource ToSimple()
        {
            var item = this;
            return new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        private Common.Queryable.Common_LogReader _log;

        /*DataStructureQueryable PropertyAttribute Common.RelatedEventsSource.Log*/
        public virtual Common.Queryable.Common_LogReader Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.RelatedEventsSource.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RelatedEventsSource.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RelatedEventsSource*/

        public bool Equals(Common_RelatedEventsSource other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Claim*/
    public class Common_Claim : global::Common.Claim, IQueryableEntity<Common.Claim>, System.IEquatable<Common_Claim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Claim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Claim ToSimple()
        {
            var item = this;
            return new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        private Common.Queryable.Common_MyClaim _extension_MyClaim;

        /*DataStructureQueryable PropertyAttribute Common.Claim.Extension_MyClaim*/
        public virtual Common.Queryable.Common_MyClaim Extension_MyClaim
        {
            get
            {
                /*DataStructureQueryable Getter Common.Claim.Extension_MyClaim*/
                return _extension_MyClaim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.Claim.Extension_MyClaim*/
                _extension_MyClaim = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.Claim*/

        public bool Equals(Common_Claim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.MyClaim*/
    public class Common_MyClaim : global::Common.MyClaim, IQueryableEntity<Common.MyClaim>, System.IEquatable<Common_MyClaim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.MyClaim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.MyClaim ToSimple()
        {
            var item = this;
            return new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        private Common.Queryable.Common_Claim _base;

        /*DataStructureQueryable PropertyAttribute Common.MyClaim.Base*/
        public virtual Common.Queryable.Common_Claim Base
        {
            get
            {
                /*DataStructureQueryable Getter Common.MyClaim.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.MyClaim.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.MyClaim*/

        public bool Equals(Common_MyClaim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Principal*/
    public class Common_Principal : global::Common.Principal, IQueryableEntity<Common.Principal>, System.IEquatable<Common_Principal>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Principal*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Principal ToSimple()
        {
            var item = this;
            return new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Principal*/

        public bool Equals(Common_Principal other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalHasRole*/
    public class Common_PrincipalHasRole : global::Common.PrincipalHasRole, IQueryableEntity<Common.PrincipalHasRole>, System.IEquatable<Common_PrincipalHasRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalHasRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalHasRole ToSimple()
        {
            var item = this;
            return new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalHasRole*/

        public bool Equals(Common_PrincipalHasRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Role*/
    public class Common_Role : global::Common.Role, IQueryableEntity<Common.Role>, System.IEquatable<Common_Role>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Role*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Role ToSimple()
        {
            var item = this;
            return new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Role*/

        public bool Equals(Common_Role other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RoleInheritsRole*/
    public class Common_RoleInheritsRole : global::Common.RoleInheritsRole, IQueryableEntity<Common.RoleInheritsRole>, System.IEquatable<Common_RoleInheritsRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RoleInheritsRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RoleInheritsRole ToSimple()
        {
            var item = this;
            return new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        private Common.Queryable.Common_Role _usersFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.UsersFrom*/
        public virtual Common.Queryable.Common_Role UsersFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.UsersFrom*/
                return _usersFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.UsersFrom*/
                _usersFrom = value;
                UsersFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _permissionsFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.PermissionsFrom*/
        public virtual Common.Queryable.Common_Role PermissionsFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.PermissionsFrom*/
                return _permissionsFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.PermissionsFrom*/
                _permissionsFrom = value;
                PermissionsFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RoleInheritsRole*/

        public bool Equals(Common_RoleInheritsRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalPermission*/
    public class Common_PrincipalPermission : global::Common.PrincipalPermission, IQueryableEntity<Common.PrincipalPermission>, System.IEquatable<Common_PrincipalPermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalPermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalPermission ToSimple()
        {
            var item = this;
            return new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalPermission*/

        public bool Equals(Common_PrincipalPermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RolePermission*/
    public class Common_RolePermission : global::Common.RolePermission, IQueryableEntity<Common.RolePermission>, System.IEquatable<Common_RolePermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RolePermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RolePermission ToSimple()
        {
            var item = this;
            return new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RolePermission*/

        public bool Equals(Common_RolePermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.Hotel*/
    public class HotelRhetos_Hotel : global::HotelRhetos.Hotel, IQueryableEntity<HotelRhetos.Hotel>, System.IEquatable<HotelRhetos_Hotel>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.Hotel*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.Hotel ToSimple()
        {
            var item = this;
            return new HotelRhetos.Hotel
            {
                ID = item.ID,
                Name = item.Name,
                Address = item.Address/*DataStructureInfo AssignSimpleProperty HotelRhetos.Hotel*/
            };
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.Hotel*/

        public bool Equals(HotelRhetos_Hotel other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.Room*/
    public class HotelRhetos_Room : global::HotelRhetos.Room, IQueryableEntity<HotelRhetos.Room>, System.IEquatable<HotelRhetos_Room>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.Room*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.Room ToSimple()
        {
            var item = this;
            return new HotelRhetos.Room
            {
                ID = item.ID,
                Name = item.Name,
                Description = item.Description,
                HotelID = item.HotelID,
                RoomTypeID = item.RoomTypeID,
                CreatedAt = item.CreatedAt/*DataStructureInfo AssignSimpleProperty HotelRhetos.Room*/
            };
        }

        private Common.Queryable.HotelRhetos_Hotel _hotel;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Room.Hotel*/
        public virtual Common.Queryable.HotelRhetos_Hotel Hotel
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Room.Hotel*/
                return _hotel;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Room.Hotel*/
                _hotel = value;
                HotelID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.HotelRhetos_RoomType _roomType;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Room.RoomType*/
        public virtual Common.Queryable.HotelRhetos_RoomType RoomType
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Room.RoomType*/
                return _roomType;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Room.RoomType*/
                _roomType = value;
                RoomTypeID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.HotelRhetos_RomNumberOfReservations _extension_RomNumberOfReservations;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Room.Extension_RomNumberOfReservations*/
        public virtual Common.Queryable.HotelRhetos_RomNumberOfReservations Extension_RomNumberOfReservations
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Room.Extension_RomNumberOfReservations*/
                return _extension_RomNumberOfReservations;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Room.Extension_RomNumberOfReservations*/
                _extension_RomNumberOfReservations = value;
            }
        }

        private Common.Queryable.HotelRhetos_RoomGrid _extension_RoomGrid;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Room.Extension_RoomGrid*/
        public virtual Common.Queryable.HotelRhetos_RoomGrid Extension_RoomGrid
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Room.Extension_RoomGrid*/
                return _extension_RoomGrid;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Room.Extension_RoomGrid*/
                _extension_RoomGrid = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.Room*/

        public bool Equals(HotelRhetos_Room other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.RoomType*/
    public class HotelRhetos_RoomType : global::HotelRhetos.RoomType, IQueryableEntity<HotelRhetos.RoomType>, System.IEquatable<HotelRhetos_RoomType>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.RoomType*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.RoomType ToSimple()
        {
            var item = this;
            return new HotelRhetos.RoomType
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price,
                CreatedAt = item.CreatedAt/*DataStructureInfo AssignSimpleProperty HotelRhetos.RoomType*/
            };
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.RoomType*/

        public bool Equals(HotelRhetos_RoomType other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.Guest*/
    public class HotelRhetos_Guest : global::HotelRhetos.Guest, IQueryableEntity<HotelRhetos.Guest>, System.IEquatable<HotelRhetos_Guest>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.Guest*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.Guest ToSimple()
        {
            var item = this;
            return new HotelRhetos.Guest
            {
                ID = item.ID,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty HotelRhetos.Guest*/
            };
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.Guest*/

        public bool Equals(HotelRhetos_Guest other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.Service*/
    public class HotelRhetos_Service : global::HotelRhetos.Service, IQueryableEntity<HotelRhetos.Service>, System.IEquatable<HotelRhetos_Service>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.Service*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.Service ToSimple()
        {
            var item = this;
            return new HotelRhetos.Service
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty HotelRhetos.Service*/
            };
        }

        private Common.Queryable.HotelRhetos_NameServices _extension_NameServices;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Service.Extension_NameServices*/
        public virtual Common.Queryable.HotelRhetos_NameServices Extension_NameServices
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Service.Extension_NameServices*/
                return _extension_NameServices;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Service.Extension_NameServices*/
                _extension_NameServices = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.Service*/

        public bool Equals(HotelRhetos_Service other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.Reservations*/
    public class HotelRhetos_Reservations : global::HotelRhetos.Reservations, IQueryableEntity<HotelRhetos.Reservations>, System.IEquatable<HotelRhetos_Reservations>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.Reservations*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.Reservations ToSimple()
        {
            var item = this;
            return new HotelRhetos.Reservations
            {
                ID = item.ID,
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
                GuestID = item.GuestID,
                RoomID = item.RoomID/*DataStructureInfo AssignSimpleProperty HotelRhetos.Reservations*/
            };
        }

        private Common.Queryable.HotelRhetos_Guest _guest;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Reservations.Guest*/
        public virtual Common.Queryable.HotelRhetos_Guest Guest
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Reservations.Guest*/
                return _guest;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Reservations.Guest*/
                _guest = value;
                GuestID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.HotelRhetos_Room _room;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Reservations.Room*/
        public virtual Common.Queryable.HotelRhetos_Room Room
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Reservations.Room*/
                return _room;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Reservations.Room*/
                _room = value;
                RoomID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.Reservations*/

        public bool Equals(HotelRhetos_Reservations other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.Invoice*/
    public class HotelRhetos_Invoice : global::HotelRhetos.Invoice, IQueryableEntity<HotelRhetos.Invoice>, System.IEquatable<HotelRhetos_Invoice>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.Invoice*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.Invoice ToSimple()
        {
            var item = this;
            return new HotelRhetos.Invoice
            {
                ID = item.ID,
                TotalAmount = item.TotalAmount,
                Payed = item.Payed,
                ReservationsID = item.ReservationsID/*DataStructureInfo AssignSimpleProperty HotelRhetos.Invoice*/
            };
        }

        private Common.Queryable.HotelRhetos_Reservations _reservations;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.Invoice.Reservations*/
        public virtual Common.Queryable.HotelRhetos_Reservations Reservations
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.Invoice.Reservations*/
                return _reservations;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.Invoice.Reservations*/
                _reservations = value;
                ReservationsID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.Invoice*/

        public bool Equals(HotelRhetos_Invoice other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.InvoiceItem*/
    public class HotelRhetos_InvoiceItem : global::HotelRhetos.InvoiceItem, IQueryableEntity<HotelRhetos.InvoiceItem>, System.IEquatable<HotelRhetos_InvoiceItem>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.InvoiceItem*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.InvoiceItem ToSimple()
        {
            var item = this;
            return new HotelRhetos.InvoiceItem
            {
                ID = item.ID,
                Discount = item.Discount,
                ServiceID = item.ServiceID,
                InvoiceID = item.InvoiceID/*DataStructureInfo AssignSimpleProperty HotelRhetos.InvoiceItem*/
            };
        }

        private Common.Queryable.HotelRhetos_Service _service;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.InvoiceItem.Service*/
        public virtual Common.Queryable.HotelRhetos_Service Service
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.InvoiceItem.Service*/
                return _service;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.InvoiceItem.Service*/
                _service = value;
                ServiceID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.HotelRhetos_Invoice _invoice;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.InvoiceItem.Invoice*/
        public virtual Common.Queryable.HotelRhetos_Invoice Invoice
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.InvoiceItem.Invoice*/
                return _invoice;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.InvoiceItem.Invoice*/
                _invoice = value;
                InvoiceID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.InvoiceItem*/

        public bool Equals(HotelRhetos_InvoiceItem other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.RomNumberOfReservations*/
    public class HotelRhetos_RomNumberOfReservations : global::HotelRhetos.RomNumberOfReservations, IQueryableEntity<HotelRhetos.RomNumberOfReservations>, System.IEquatable<HotelRhetos_RomNumberOfReservations>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.RomNumberOfReservations*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.RomNumberOfReservations ToSimple()
        {
            var item = this;
            return new HotelRhetos.RomNumberOfReservations
            {
                ID = item.ID,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty HotelRhetos.RomNumberOfReservations*/
            };
        }

        private Common.Queryable.HotelRhetos_Room _base;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.RomNumberOfReservations.Base*/
        public virtual Common.Queryable.HotelRhetos_Room Base
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.RomNumberOfReservations.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.RomNumberOfReservations.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.RomNumberOfReservations*/

        public bool Equals(HotelRhetos_RomNumberOfReservations other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.RoomGrid*/
    public class HotelRhetos_RoomGrid : global::HotelRhetos.RoomGrid, IQueryableEntity<HotelRhetos.RoomGrid>, System.IEquatable<HotelRhetos_RoomGrid>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.RoomGrid*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.RoomGrid ToSimple()
        {
            var item = this;
            return new HotelRhetos.RoomGrid
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelName = item.HotelName,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty HotelRhetos.RoomGrid*/
            };
        }

        private Common.Queryable.HotelRhetos_Room _base;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.RoomGrid.Base*/
        public virtual Common.Queryable.HotelRhetos_Room Base
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.RoomGrid.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.RoomGrid.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.RoomGrid*/

        public bool Equals(HotelRhetos_RoomGrid other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes HotelRhetos.NameServices*/
    public class HotelRhetos_NameServices : global::HotelRhetos.NameServices, IQueryableEntity<HotelRhetos.NameServices>, System.IEquatable<HotelRhetos_NameServices>, IDetachOverride/*DataStructureInfo QueryableClassInterace HotelRhetos.NameServices*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public HotelRhetos.NameServices ToSimple()
        {
            var item = this;
            return new HotelRhetos.NameServices
            {
                ID = item.ID,
                Price = item.Price,
                Price1 = item.Price1/*DataStructureInfo AssignSimpleProperty HotelRhetos.NameServices*/
            };
        }

        private Common.Queryable.HotelRhetos_Service _base;

        /*DataStructureQueryable PropertyAttribute HotelRhetos.NameServices.Base*/
        public virtual Common.Queryable.HotelRhetos_Service Base
        {
            get
            {
                /*DataStructureQueryable Getter HotelRhetos.NameServices.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter HotelRhetos.NameServices.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers HotelRhetos.NameServices*/

        public bool Equals(HotelRhetos_NameServices other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*CommonQueryableMemebers*/
}

namespace Rhetos.Dom.DefaultConcepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    public static class QueryExtensions
    {
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AutoCodeCache> ToSimple(this IQueryable<Common.Queryable.Common_AutoCodeCache> query)
        {
            return query.Select(item => new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.FilterId> ToSimple(this IQueryable<Common.Queryable.Common_FilterId> query)
        {
            return query.Select(item => new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.KeepSynchronizedMetadata> ToSimple(this IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> query)
        {
            return query.Select(item => new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ExclusiveLock> ToSimple(this IQueryable<Common.Queryable.Common_ExclusiveLock> query)
        {
            return query.Select(item => new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogReader> ToSimple(this IQueryable<Common.Queryable.Common_LogReader> query)
        {
            return query.Select(item => new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItemReader> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItemReader> query)
        {
            return query.Select(item => new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Log> ToSimple(this IQueryable<Common.Queryable.Common_Log> query)
        {
            return query.Select(item => new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItem> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItem> query)
        {
            return query.Select(item => new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RelatedEventsSource> ToSimple(this IQueryable<Common.Queryable.Common_RelatedEventsSource> query)
        {
            return query.Select(item => new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Claim> ToSimple(this IQueryable<Common.Queryable.Common_Claim> query)
        {
            return query.Select(item => new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.MyClaim> ToSimple(this IQueryable<Common.Queryable.Common_MyClaim> query)
        {
            return query.Select(item => new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Principal> ToSimple(this IQueryable<Common.Queryable.Common_Principal> query)
        {
            return query.Select(item => new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalHasRole> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalHasRole> query)
        {
            return query.Select(item => new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Role> ToSimple(this IQueryable<Common.Queryable.Common_Role> query)
        {
            return query.Select(item => new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RoleInheritsRole> ToSimple(this IQueryable<Common.Queryable.Common_RoleInheritsRole> query)
        {
            return query.Select(item => new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalPermission> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalPermission> query)
        {
            return query.Select(item => new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RolePermission> ToSimple(this IQueryable<Common.Queryable.Common_RolePermission> query)
        {
            return query.Select(item => new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.Hotel> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_Hotel> query)
        {
            return query.Select(item => new HotelRhetos.Hotel
            {
                ID = item.ID,
                Name = item.Name,
                Address = item.Address/*DataStructureInfo AssignSimpleProperty HotelRhetos.Hotel*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.Room> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_Room> query)
        {
            return query.Select(item => new HotelRhetos.Room
            {
                ID = item.ID,
                Name = item.Name,
                Description = item.Description,
                HotelID = item.HotelID,
                RoomTypeID = item.RoomTypeID,
                CreatedAt = item.CreatedAt/*DataStructureInfo AssignSimpleProperty HotelRhetos.Room*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.RoomType> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_RoomType> query)
        {
            return query.Select(item => new HotelRhetos.RoomType
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price,
                CreatedAt = item.CreatedAt/*DataStructureInfo AssignSimpleProperty HotelRhetos.RoomType*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.Guest> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_Guest> query)
        {
            return query.Select(item => new HotelRhetos.Guest
            {
                ID = item.ID,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty HotelRhetos.Guest*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.Service> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_Service> query)
        {
            return query.Select(item => new HotelRhetos.Service
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price/*DataStructureInfo AssignSimpleProperty HotelRhetos.Service*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.Reservations> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_Reservations> query)
        {
            return query.Select(item => new HotelRhetos.Reservations
            {
                ID = item.ID,
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
                GuestID = item.GuestID,
                RoomID = item.RoomID/*DataStructureInfo AssignSimpleProperty HotelRhetos.Reservations*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.Invoice> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_Invoice> query)
        {
            return query.Select(item => new HotelRhetos.Invoice
            {
                ID = item.ID,
                TotalAmount = item.TotalAmount,
                Payed = item.Payed,
                ReservationsID = item.ReservationsID/*DataStructureInfo AssignSimpleProperty HotelRhetos.Invoice*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.InvoiceItem> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_InvoiceItem> query)
        {
            return query.Select(item => new HotelRhetos.InvoiceItem
            {
                ID = item.ID,
                Discount = item.Discount,
                ServiceID = item.ServiceID,
                InvoiceID = item.InvoiceID/*DataStructureInfo AssignSimpleProperty HotelRhetos.InvoiceItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.RomNumberOfReservations> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_RomNumberOfReservations> query)
        {
            return query.Select(item => new HotelRhetos.RomNumberOfReservations
            {
                ID = item.ID,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty HotelRhetos.RomNumberOfReservations*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.RoomGrid> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_RoomGrid> query)
        {
            return query.Select(item => new HotelRhetos.RoomGrid
            {
                ID = item.ID,
                RoomNumber = item.RoomNumber,
                HotelName = item.HotelName,
                NumberOfReservations = item.NumberOfReservations/*DataStructureInfo AssignSimpleProperty HotelRhetos.RoomGrid*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<HotelRhetos.NameServices> ToSimple(this IQueryable<Common.Queryable.HotelRhetos_NameServices> query)
        {
            return query.Select(item => new HotelRhetos.NameServices
            {
                ID = item.ID,
                Price = item.Price,
                Price1 = item.Price1/*DataStructureInfo AssignSimpleProperty HotelRhetos.NameServices*/
            });
        }
        /*QueryExtensionsMembers*/

        /// <summary>
        /// A specific overload of the 'ToSimple' method cannot be targeted from a generic method using generic type.
        /// This method uses reflection instead to find the specific 'ToSimple' method.
        /// </summary>
        public static IQueryable<TEntity> GenericToSimple<TEntity>(this IQueryable<IEntity> i)
            where TEntity : class, IEntity
	    {
            var method = typeof(QueryExtensions).GetMethod("ToSimple", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public, null, new Type[] { i.GetType() }, null);
            if (method == null)
                throw new Rhetos.FrameworkException("Cannot find 'ToSimple' method for argument type '" + i.GetType().ToString() + "'.");
            return (IQueryable<TEntity>)Rhetos.Utilities.ExceptionsUtility.InvokeEx(method, null, new object[] { i });
        }

        /// <summary>Converts the objects to simple object and the IEnumerable to List or Array, if not already.</summary>
        public static void LoadSimpleObjects<TEntity>(ref IEnumerable<TEntity> items)
            where TEntity: class, IEntity
        {
            var query = items as IQueryable<IQueryableEntity<TEntity>>;
            var navigationItems = items as IEnumerable<IQueryableEntity<TEntity>>;

            if (query != null)
                items = query.GenericToSimple<TEntity>().ToList(); // The IQueryable function allows ORM optimizations.
            else if (navigationItems != null)
                items = navigationItems.Select(item => item.ToSimple()).ToList();
            else
            {
                Rhetos.Utilities.CsUtility.Materialize(ref items);
                var itemsList = (IList<TEntity>)items;
                for (int i = 0; i < itemsList.Count(); i++)
                {
                    var navigationItem = itemsList[i] as IQueryableEntity<TEntity>;
                    if (navigationItem != null)
                        itemsList[i] = navigationItem.ToSimple();
                }
            }
        }
    }
}