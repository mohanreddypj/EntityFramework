// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;

namespace Microsoft.Data.Entity.InMemory
{
    public class InMemoryModelSource : DefaultModelSource
    {
        public InMemoryModelSource([NotNull] DbSetFinder setFinder)
            : base(setFinder)
        {
        }
    }
}
