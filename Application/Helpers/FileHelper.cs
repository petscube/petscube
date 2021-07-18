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
  public class AwsFileHelper : IFileHelper
  {
    private readonly RegionEndpoint bucketRegion = RegionEndpoint.APSouth1;
    private string bucketName;
    private TransferUtility fileTransferUtility;
    public AwsFileHelper(IConfiguration configuration)
    {
      bucketName = configuration.GetValue<string>("AWSConfigs:S3Bucket");
      var s3Client = new AmazonS3Client(bucketRegion);
      fileTransferUtility = new TransferUtility(s3Client);
    }
    public async Task UploadFile(Stream FileStream, string fileName)
    {
      var uploadRequest = new TransferUtilityUploadRequest
      {
        Key=fileName,
        BucketName = bucketName,
        
        CannedACL = S3CannedACL.PublicRead,
        InputStream=FileStream,
      };

      await fileTransferUtility.UploadAsync(uploadRequest);
    }
  }
}
