using Abp.AspNetZeroCore.Net;
using Abp.Extensions;
using Abp.IO.Extensions;
using Abp.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PionereeDemo.Authorization.Users.Profile;
using PionereeDemo.Dto;
using PionereeDemo.Storage;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PionereeDemo.Web.Controllers;

public abstract class ProfileControllerBase : PionereeDemoControllerBase
{
    private readonly ITempFileCacheManager _tempFileCacheManager;
    private readonly IProfileAppService _profileAppService;

    protected ProfileControllerBase(
        ITempFileCacheManager tempFileCacheManager,
        IProfileAppService profileAppService)
    {
        _tempFileCacheManager = tempFileCacheManager;
        _profileAppService = profileAppService;
    }

    public void UploadProfilePictureFile(FileDto input)
    {
        var profilePictureFile = Request.Form.Files.First();

        //Check input
        if (profilePictureFile == null)
        {
            throw new UserFriendlyException(L("ProfilePicture_Change_Error"));
        }

        using (var stream = profilePictureFile.OpenReadStream())
        {
            byte[] fileBytes;
            fileBytes = stream.GetAllBytes();

            _tempFileCacheManager.SetFile(input.FileToken, fileBytes);
        }

    }

    [AllowAnonymous]
    public FileResult GetDefaultProfilePicture()
    {
        return GetDefaultProfilePictureInternal();
    }

    public async Task<FileResult> GetProfilePictureByUser(long userId)
    {
        var output = await _profileAppService.GetProfilePictureByUser(userId);
        if (output.ProfilePicture.IsNullOrEmpty())
        {
            return GetDefaultProfilePictureInternal();
        }

        return File(Convert.FromBase64String(output.ProfilePicture), MimeTypeNames.ImageJpeg);
    }

    protected FileResult GetDefaultProfilePictureInternal()
    {
        return File(Path.Combine("Common", "Images", "default-profile-picture.png"), MimeTypeNames.ImagePng);
    }
}

