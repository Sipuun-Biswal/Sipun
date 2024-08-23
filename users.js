document.addEventListener('DOMContentLoaded', function() {
    const usersTableBody = document.querySelector('#usersTable tbody');

    for (let i = 0; i < localStorage.length; i++) {
        const email = localStorage.key(i);
        const user = JSON.parse(localStorage.getItem(email));

        const row = document.createElement('tr');
        const usernameCell = document.createElement('td');
        const emailCell = document.createElement('td');

        usernameCell.textContent = user.username;
        emailCell.textContent = user.email;

        row.appendChild(usernameCell);
        row.appendChild(emailCell);

        usersTableBody.appendChild(row);
    }
});
