﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using hrOT.Application.Common.Interfaces;
using hrOT.Application.Exchanges.Commands.CreateExchange;

namespace hrOT.Application.TaxInComes.Commands.CreateTaxInCome;
public class CreateTaxInComeCommandValidator : AbstractValidator<CreateTaxInComeCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateTaxInComeCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Muc_chiu_thue)
            .NotNull().WithMessage("Mức chịu thuế không được để trống.")
            .GreaterThan(0).WithMessage("Mức chịu thuế phải lớn hơn 0.");

        RuleFor(v => v.Thue_suat)
            .NotNull().WithMessage("Thuế suất không được để trống.")
            .GreaterThan(0).WithMessage("Thuế suất phải lớn hơn 0.");
    }
}

