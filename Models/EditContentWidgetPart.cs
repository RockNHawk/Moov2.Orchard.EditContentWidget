using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;

namespace Moov2.Orchard.EditContentWidget.Models {
    public class EditContentWidgetPart : ContentPart {
        internal LazyField<ContentItem> CurrentContentItemField = new LazyField<ContentItem>();

        public ContentItem CurrentContentItem {
            get { return CurrentContentItemField.Value; }
        }
    }
}