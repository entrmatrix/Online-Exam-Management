﻿




$(document).ready(function () {

    var orgId = $("#OrganizationId").val();
    if (orgId != "" && orgId != undefined) {
        loadCourseByOrgId(orgId);
    }


    //Get Courses By Organization
    $("#OrganizationId").change(function () {

        orgId = $(this).val();

        if (orgId != "" && orgId != undefined) {

            loadCourseByOrgId(orgId);

        }

    });



    //Batch Number Generate By Course
    $("#courseListDD").change(function () {

        var crsId = $(this).val();

        if (crsId != "") {
            var params = { id: crsId }

            $.ajax({
                type: "POST",
                url: "../../Batch/GetBatchNoByCourseId",
                contentType: "application/JSON; charset=utf-8",
                data: JSON.stringify(params),

                success: function (rData) {
                    if (rData > 0) {
                        $(".BatchNo").empty();
                        $(".BatchNo").val(rData + 1);
                    } else {
                        $(".BatchNo").val(1);
                    }
                }
            });
        }

    });

});


function loadCourseByOrgId(orgId) {
    var params = { id: orgId };
    $.ajax({
        type: "POST",
        url: "../../Batch/GetCourseByOrganizationId",
        contentType: "application/JSON; charset=utf-8",
        data: JSON.stringify(params),

        success: function (rData) {
            if (rData != undefined && rData != "") {
                $("#courseListDD").empty();
                $("#courseListDD").append("<option value=''>Select Course</option>");

                $.each(rData,
                    function (k, v) {
                        var option = "<option value='" + v.Id + "'>" + v.Name + "</option>";
                        $("#courseListDD").append(option);
                    });
            } else {
                $("#courseListDD").empty();
                $("#courseListDD").append("<option value=''>Select Course</option>");
            }
        }
    });
}