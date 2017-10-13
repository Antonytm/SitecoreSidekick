﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainbow.Model;
using Sitecore.Data;

namespace ScsEditingContext.Services.Interface
{
	public interface ISitecoreDataAccessService
	{
		IEnumerable<IItemData> GetItemReferences(IItemData itemData);
		IEnumerable<IItemData> GetItemReferrers(IItemData itemData);
		bool TryGetItemData(string id, out IItemData itemData);
		IItemData GetLatestItemData(string id, Database db = null);
	}
}
