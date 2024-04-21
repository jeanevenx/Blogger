﻿namespace Blogger.APIs.Contracts.MakeComment;

public class ReplayToCommetRequestValidator : AbstractValidator<ReplayToCommetRequest>
{
    public ReplayToCommetRequestValidator()
    {
        RuleFor(x => x.ArticleId)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Content)
            .MaximumLength(500)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.FullName)
            .MaximumLength(100)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Email)
            .MaximumLength(1044)
            .NotEmpty()
            .NotNull();
    }
}