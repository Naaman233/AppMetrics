﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using App.Metrics.Core.Interfaces;

namespace App.Metrics.Histogram.Interfaces
{
    /// <summary>
    ///     A Histogram measures the distribution of values in a stream of data: e.g., the number of results returned by a
    ///     search.
    /// </summary>
    public interface IHistogram : IResetableMetric
    {
        /// <summary>
        ///     Records a value.
        /// </summary>
        /// <param name="value">Value to be added to the histogram.</param>
        /// <param name="userValue">
        ///     A custom user value that will be associated to the results.
        ///     Useful for tracking (for example) for which id the max or min value was recorded.
        /// </param>
        void Update(long value, string userValue);

        /// <summary>
        ///     Records a value.
        /// </summary>
        /// <param name="value">Value to be added to the histogram.</param>
        void Update(long value);
    }
}