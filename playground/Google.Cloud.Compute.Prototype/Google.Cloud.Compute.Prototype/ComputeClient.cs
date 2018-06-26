using Google.Api.Gax.Rest;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Compute.v1;
using Google.Apis.Services;

namespace Google.Cloud.Compute.Prototype
{
    public partial class ComputeClient
    {
        private static readonly ScopedCredentialProvider _credentialProvider = new ScopedCredentialProvider(
            new[] {
                ComputeService.Scope.ComputeReadonly,
                ComputeService.Scope.Compute,
                ComputeService.Scope.DevstorageReadOnly,
                ComputeService.Scope.DevstorageReadWrite,
                ComputeService.Scope.DevstorageFullControl,
                ComputeService.Scope.CloudPlatform
            });

        public string Project { get; }
        public ComputeService InternalService { get; }

        internal ComputeClient(ComputeService client, string project = null)
        {
            InternalService = client;
            Project = project;

            InitResources();
        }

        partial void InitResources();

        public static ComputeClient Create(string project = null, GoogleCredential credential = null)
        {
            GoogleCredential scopedCredentials = _credentialProvider.GetCredentials(credential);
            BaseClientService.Initializer serviceInitializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials
            };
            return new ComputeClient(new ComputeService(serviceInitializer), project);
        }
    }
}
