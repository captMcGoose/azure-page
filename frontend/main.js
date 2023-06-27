window.addEventListener('DOMContentLoaded', (event) => {
    getVisitCount();
})

const localFunctionApi = 'http://localhost:7071/api/GetResumeCounter';
const functionApiUrl = 'https://getresumecountertal.azurewebsites.net/api/GetResumeCounter?code=I6t2487diof_Mwdh9AtBIpodWFYHAt0NILdpjCD282viAzFuTZdAaQ==';

const getVisitCount = () => {
    let count = 30;
    fetch(functionApiUrl).then(response => {
        return response.json()
    }).then(response => {
        console.log("Da Website called da function API");
        count = response.count;
        document.getElementById("counter").innerText = count;
    }).catch(function(error){
        console.log(error);
    });
    return count;
}