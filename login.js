document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    const email = document.getElementById('loginEmail').value.toLowerCase();
    const password = document.getElementById('loginPassword').value;
    
    const storedUser = localStorage.getItem("Users");
    
    if (storedUser) {
        const user = JSON.parse(storedUser);
        if (user.password === password) {
            alert('Login successful!');
            window.location.href = 'users.html'; // Redirect to users page
        } else {
            alert('Incorrect password!');
        }
    } else {
        alert('User not found!');
    }
});

