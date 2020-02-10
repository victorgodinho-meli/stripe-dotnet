namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxIdService : ServiceNested<TaxId>,
        INestedCreatable<TaxId, TaxIdCreateOptions>,
        INestedListable<TaxId, TaxIdListOptions>,
        INestedRetrievable<TaxId, TaxIdGetOptions>
    {
        public TaxIdService()
            : base(null)
        {
        }

        public TaxIdService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/tax_ids";

        public virtual TaxId Create(string parentId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<TaxId> CreateAsync(string parentId, TaxIdCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual TaxId Delete(string parentId, string id, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(parentId, id, null, requestOptions);
        }

        public virtual Task<TaxId> DeleteAsync(string parentId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(parentId, id, null, requestOptions, cancellationToken);
        }

        public virtual TaxId Get(string parentId, string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<TaxId> GetAsync(string parentId, string id, TaxIdGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TaxId> List(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<TaxId>> ListAsync(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TaxId> ListAutoPaging(string parentId, TaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }
    }
}
