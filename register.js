document.getElementById('registerForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    const username = document.getElementById('username').value;
    const email = document.getElementById('email').value.toLowerCase();
    const password = document.getElementById('password').value;
    
    if (localStorage.getItem(email)) {
        alert('Email already exists!');
    } else {
        const user = { username, email, password };
        localStorage.setItem(email, JSON.stringify(user));
        alert('Registration successful!');
        window.location.href = 'login.html'; // Redirect to login page
    }
});
