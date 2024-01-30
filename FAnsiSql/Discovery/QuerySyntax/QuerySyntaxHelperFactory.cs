﻿using FAnsi.Implementation;

namespace FAnsi.Discovery.QuerySyntax;

/// <summary>
/// Translates a DatabaseType into the correct IQuerySyntaxHelper.
/// </summary>
public sealed class QuerySyntaxHelperFactory
{
    public static IQuerySyntaxHelper Create(DatabaseType type) => ImplementationManager.GetImplementation(type).GetQuerySyntaxHelper();
}