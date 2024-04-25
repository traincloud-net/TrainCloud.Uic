﻿using System.ComponentModel.DataAnnotations;
using TrainCloud.Uic.Services;

namespace TrainCloud.Uic.DataAnnotations;

/// <summary>
/// Specifies that a data field value is a valid UIC number.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
public class UicNumberAttribute : ValidationAttribute
{
    /// <summary>
    /// Checks that the value of the required data field is a valid UIC number.
    /// </summary>
    /// <param name="value">The data field value to validate.</param>
    /// <returns>True if validation is successful; otherwise, false.</returns>
    public override bool IsValid(object? value)
    {
        if(value is null)
        {
            return false;
        }

        UicNumberService uicNumberService = new();

        return uicNumberService.ValidateUic(value.ToString()!);
    }
}