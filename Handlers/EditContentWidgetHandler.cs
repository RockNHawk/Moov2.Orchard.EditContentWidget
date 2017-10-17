using Moov2.Orchard.EditContentWidget.Models;
using Moov2.Orchard.EditContentWidget.Services;
using Orchard.ContentManagement.Handlers;

namespace Moov2.Orchard.EditContentWidget.Handlers {
    public class EditContentWidgetHandler : ContentHandler {
        private readonly ICurrentContentAccessor _currentContentAccessor;

        public EditContentWidgetHandler(ICurrentContentAccessor currentContentAccessor) {
            _currentContentAccessor = currentContentAccessor;
            OnActivated<EditContentWidgetPart>(SetupLazyFields);
        }

        private void SetupLazyFields(ActivatedContentContext context, EditContentWidgetPart part) {
            part.CurrentContentItemField.Loader(() => _currentContentAccessor.CurrentContentItem);
        }
    }
}
