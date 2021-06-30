using System;
using System.Collections.Generic;
using System.Text;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Application.Helpers
{
  public class AwsFileHelper :IFileHelper 
    {
      private readonly RegionEndpoint bucketRegion= RegionEndpoint.APSouth1;
      private IAmazonS3 s3Client;
      private string bucketName;
      public AwsFileHelper(IConfiguration configuration)
      {
        bucketName= configuration.GetValue<string>("AWSConfigs:S3Bucket");
        s3Client = new AmazonS3Client(bucketRegion);
      } 
      public async Task UploadFile(Stream FileStream,string fileName)
      {
        
        var fileTransferUtility = new TransferUtility(s3Client);
        await fileTransferUtility.UploadAsync(FileStream, bucketName, fileName);
      } 
     }
  }
