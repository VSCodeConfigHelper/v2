const lanzousLink = "https://ww.lanzous.com/b01bf37ha";
const lanzousCode = "gei7";
var versionInfo;
function download() {
    window.open(versionInfo.link);
}

$.getJSON("version.json", function (result) {
    versionInfo = result;
    console.log(versionInfo);
    $("#version-text").text("版本 " + versionInfo.version + " 更新日期 " + versionInfo.date);
});

$("[data-toggle='popover']").popover({
    html: true,
    title: "使用蓝奏云下载",
    trigger: "click",
    content: function () {
        return lanzousPopup();
    }
});

$.getJSON("https://api.countapi.xyz/get/guyutongxue.github.io/b54f2252-e54a-4bd0-b4c2-33b47db6aa98", result => {
    const count = new countUp.CountUp('successCount', result.value, {prefix: '>'});
    count.start();
});

function lanzousPopup() {
    let data = $(`
<span class='label label-info'>链接</span>
    <button class='btn btn-link' onclick='window.open("${lanzousLink}");'>${lanzousLink}</button><br>
    <span class='label label-info'>密码</span>
    <div class='input-group input-group-sm'>
        <input type='text' class='form-control' id='passcode' value='${lanzousCode}' readonly></input>
    <span class='input-group-btn'>
        <button class='btn btn-default' id='copybtn' data-clipboard-target='#passcode' type='submit'>复制</button>  
    </span>
</div>`);
    return data;
}

$(document).ready(() => {
    const clipboard = new ClipboardJS('#copybtn');
})