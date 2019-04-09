using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace HotelRhetos.Concepts
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("TrackedRecord")]
    public class TrackedRecordInfo : IConceptInfo
    {
        [ConceptKey]
        public EntityInfo Entity { get; set; }
    }
    [Export(typeof(IConceptMacro))]
    public class TrackRecordMacro : IConceptMacro<TrackedRecordInfo>
    {
        public IEnumerable<IConceptInfo> CreateNewConcepts(
            TrackedRecordInfo conceptInfo, IDslModel existingConcepts)
        {
            var newConcepts = new List<IConceptInfo>();

            var propertyCreatedAt = new DateTimePropertyInfo
            {
                Name = "CreatedAt",
                DataStructure = conceptInfo.Entity
            };
            newConcepts.Add(propertyCreatedAt);
            newConcepts.Add(new CreationTimeInfo
            {
                Property = propertyCreatedAt
            });

            var entityLogging = new EntityLoggingInfo
            {
                Entity = conceptInfo.Entity
            };
            newConcepts.Add(entityLogging);
            newConcepts.Add(new AllPropertiesLoggingInfo
            {
                EntityLogging = entityLogging
            });

            return newConcepts;
        }
        
    }
}
