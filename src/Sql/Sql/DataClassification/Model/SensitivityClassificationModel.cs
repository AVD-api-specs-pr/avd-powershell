﻿using Microsoft.Azure.Commands.Sql.DataClassification.Services;
using Microsoft.WindowsAzure.Commands.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.Sql.DataClassification.Model
{
    public abstract class SensitivityClassificationModel
    {
        [Ps1Xml(Target = ViewControl.List, Position = 0)]
        public string ResourceGroupName { get; set; }

        [Ps1Xml(Target = ViewControl.List, Position = 2)]
        public string DatabaseName { get; set; }

        [Ps1Xml(Target = ViewControl.List)]
        public List<SensitivityLabelModel> SensitivityLabels { get; set; }

        internal void ApplyModel(SensitivityClassificationModel model, InformationProtectionPolicy policy)
        {
            SensitivityLabels = MergeSensitivityLabels(SensitivityLabels, model.SensitivityLabels, policy);
        }

        private static List<SensitivityLabelModel> MergeSensitivityLabels(
            List<SensitivityLabelModel> existingLabels,
            List<SensitivityLabelModel> newLabels,
            InformationProtectionPolicy informationProtectionPolicy)
        {
            List<SensitivityLabelModel> mergedLabels = new List<SensitivityLabelModel>();
            if (newLabels == null)
            {
                return mergedLabels;
            }

            if (existingLabels == null)
            {
                return newLabels;
            }

            SortComparer comparer = new SortComparer();
            existingLabels.Sort(comparer);
            newLabels.Sort(comparer);


            int existingLabelsIndex = 0;
            int existingLabelsCount = existingLabels.Count();

            int newLabelsIndex = 0;
            int newLabelsCount = newLabels.Count();

            while (existingLabelsIndex < existingLabelsCount && newLabelsIndex < newLabelsCount)
            {
                SensitivityLabelModel existingLabel = existingLabels.ElementAt(existingLabelsIndex);
                SensitivityLabelModel newLabel = newLabels.ElementAt(newLabelsIndex);
                int labelsCompared = comparer.Compare(existingLabel, newLabel);
                if (labelsCompared < 0)
                {
                    existingLabelsIndex++;
                }
                else if (labelsCompared > 0)
                {
                    mergedLabels.Add(newLabel);
                    newLabelsIndex++;
                }
                else
                {
                    existingLabel.ApplyModel(newLabel, informationProtectionPolicy);
                    mergedLabels.Add(existingLabel);
                    existingLabelsIndex++;
                    newLabelsIndex++;
                }
            }

            while (newLabelsIndex < newLabelsCount)
            {
                mergedLabels.Add(newLabels.ElementAt(newLabelsIndex++));
            }

            return mergedLabels;
        }

        private class SortComparer : IComparer<SensitivityLabelModel>
        {
            public int Compare(SensitivityLabelModel x, SensitivityLabelModel y)
            {
                int schemaNamesCompared = string.Compare(x.SchemaName, y.SchemaName);
                if (schemaNamesCompared != 0)
                {
                    return schemaNamesCompared;
                }

                int tableNamesCompared = string.Compare(x.TableName, y.TableName);
                if (tableNamesCompared != 0)
                {
                    return tableNamesCompared;
                }

                return string.Compare(x.ColumnName, y.ColumnName);
            }

        }
    }
}
