using System.Net.Http;
using TechnicalInterviewUI.Contracts;
using TechnicalInterviewUI.Models;

namespace TechnicalInterviewUI.Services
{
    public class DocumentInputRepository : BaseRepository<DocumentInput>, IDocumentInputRepository
    {
        private readonly IHttpClientFactory _client;
        public DocumentInputRepository(IHttpClientFactory client) : base(client)
        {
            _client = client;
        }
    }
}
