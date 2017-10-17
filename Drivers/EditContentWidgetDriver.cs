using Moov2.Orchard.EditContentWidget.Models;
using Orchard.ContentManagement.Drivers;

namespace Moov2.Orchard.EditContentWidget.Drivers {
    public class EditContentWidgetDriver : ContentPartDriver<EditContentWidgetPart> {
        protected override DriverResult Display(EditContentWidgetPart part,
          string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_EditContentWidget", () =>
              shapeHelper.Parts_EditContentWidget());
        }
    }
}
