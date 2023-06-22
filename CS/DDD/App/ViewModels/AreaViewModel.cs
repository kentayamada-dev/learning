﻿using Domain.Entities;

namespace App.ViewModels
{
  public sealed class AreaViewModel
  {
    private readonly AreaEntity _entity;

    public AreaViewModel(AreaEntity entity)
    {
      _entity = entity;
    }

    public string ZipCode => _entity.ZipCode.Value;
    public string StateAbbr => _entity.StateAbbr.Value;
  }
}