namespace CloudFormationCs.Resources.WAFv2
{
    using System;

    ///<summary>
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-orstatementtwo.html
    ///</summary>
    public class OrStatementTwo
    {
        public StatementThree[] Statements
        {
            get;
            set;
        }
    }
}