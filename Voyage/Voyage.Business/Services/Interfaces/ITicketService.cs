﻿using Voyage.Common.RequestModels;
using Voyage.Common.ResponseModels;

namespace Voyage.Business.Services.Interfaces
{
    public interface ITicketService
    {
        Task<TicketDetailsResponse?> GetTicketDetailsAsync(GetTicketDetailsRequest request);

        Task<IEnumerable<TicketShortInfoResponse>?> GetAsync(int page, GetTicketsRequest request, CancellationToken cancellationtoket);

        Task<TicketDetailsResponse> CreateAsync(CreateTicketRequest request);

        Task<bool> DeleteAsync(DeleteTicketRequest request);
    }
}
