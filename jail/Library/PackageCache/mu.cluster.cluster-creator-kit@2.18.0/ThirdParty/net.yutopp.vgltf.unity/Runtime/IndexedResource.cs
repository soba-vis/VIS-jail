//
// Copyright (c) 2019- yutopp (yutopp@gmail.com)
//
// Distributed under the Boost Software License, Version 1.0. (See accompanying
// file LICENSE_1_0.txt or copy at  https://www.boost.org/LICENSE_1_0.txt)
//

namespace VGltf.Unity
{
    public sealed class IndexedResource<T>
    {
        public readonly int Index;
        public readonly T Value;

        public IndexedResource(int index, T value)
        {
            Index = index;
            Value = value;
        }
    }
}
