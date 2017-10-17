using Orchard.ContentManagement.MetaData;
using Orchard.Data.Migration;

namespace Asmodee.Orchard.EditContentWidget {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            ContentDefinitionManager.AlterTypeDefinition("EditContentWidget",
                cfg => cfg
                    .WithPart("EditContentWidgetPart")
                    .WithPart("CommonPart")
                    .WithPart("WidgetPart")
                    .WithSetting("Stereotype", "Widget")
                    .WithIdentity()
                );

            return 1;
        }
    }
}