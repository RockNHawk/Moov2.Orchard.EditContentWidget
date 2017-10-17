﻿using System.Web.Routing;
using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;

namespace Moov2.Orchard.EditContentWidget.Services {
    public interface ICurrentContentAccessor : IDependency {
        ContentItem CurrentContentItem { get; }
    }

    public class CurrentContentAccessor : ICurrentContentAccessor {
        private readonly LazyField<ContentItem> _currentContentItemField = new LazyField<ContentItem>();
        private readonly IContentManager _contentManager;
        private readonly RequestContext _requestContext;

        public CurrentContentAccessor(IContentManager contentManager, RequestContext requestContext) {
            _contentManager = contentManager;
            _requestContext = requestContext;
            _currentContentItemField.Loader(GetCurrentContentItem);
        }

        public ContentItem CurrentContentItem {
            get { return _currentContentItemField.Value; }
        }

        private ContentItem GetCurrentContentItem() {
            var contentId = GetCurrentContentItemId();
            return contentId == null ? null : _contentManager.Get

         (contentId.Value);
        }

        private int? GetCurrentContentItemId() {
            object id;
            if (_requestContext.RouteData.Values.TryGetValue("id", out id)) {
                int contentId;
                if (int.TryParse(id as string, out contentId))
                    return contentId;
            }
            return null;
        }
    }
}
