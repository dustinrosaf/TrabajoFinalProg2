using System;

namespace Domain.ProductContext.Events
{
    public class ContentAddedToProduct : BaseProductEvent
    {
        public ContentAddedToProduct(Guid productId, string title, string description, AttributeRef slicerAttribute)
        {
            ProductId = productId;
            Title = title;
            Description = description;
            SlicerAttribute = slicerAttribute;
        }

        public override Guid ProductId { get; }
        public string Title { get; }
        public string Description { get; }
        public AttributeRef SlicerAttribute { get; }
    }
}