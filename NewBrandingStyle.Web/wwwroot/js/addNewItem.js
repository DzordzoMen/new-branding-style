(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        const requestData = Object.values(formElement).reduce((obj, field) => {
            if (['Name', 'IsVisible', 'Description'].includes(field.name)) {
                if (field.name === 'IsVisible') {
                    if (field.type === 'checkbox') {
                        obj[field.name] = field.value === 'true';
                    }
                } else {
                    obj[field.name] = field.value;
                }
            }
            return obj;
        }, {});
        const response = await fetch('/api/AddNewItem', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(requestData),
        }).then((data) => data);
        const responseJson = await response.json();
        if (responseJson) {
            alertElement.style.display = 'block';
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();
