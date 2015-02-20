using System;

namespace CloudFormationCs.Resources.SNS
{
    public class TopicPolicy : Resource
    {
        /*
		 * 
		 * 
"Type" : "AWS::SNS::TopicPolicy",
   "Properties" : {
      "PolicyDocument" :  {
         "Id" : "MyTopicPolicy",
         "Version" : "2012-10-17",
         "Statement" : [ {
            "Sid" : "My-statement-id",
            "Effect" : "Allow",
            "Principal" : {
               "AWS" : { "Fn::GetAtt" : [ "myuser", "Arn" ] }
            },
            "Action" : "sns:Publish",
            "Resource" : "*"
         } ]
      },
      "Topics" : [ { "Ref" : "mytopic" } ]
		 * 
		 * */

        public TopicPolicy()
            : base()
        {
        }

        public TopicPolicy(StringOrEnum resourceIdentifier)
            : base(resourceIdentifier)
        {
        }
    }
}
