﻿namespace CardStorageService.Models.Requests
{
    public interface IOperationResult
    {
        int ErrorCode { get; }

        string? ErrorMessage { get; }
    }
}
