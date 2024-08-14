package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "user")
public class User {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int uId;
    
    @Column(name = "fname")
    private String fname;
    
    @Column(name = "lname")
    private String lname;
    
    @Column(name = "email")
    private String email;
    
    @Column(name = "contact")
    private String contact;
    
    @ManyToOne
    @JoinColumn(name = "a_id")
    private Area area;
    
    @Column(name = "address")
    private String address;
    
    @ManyToOne
    @JoinColumn(name = "r_id")
    private Roles roles;
    
    @Column(name = "status")
    private byte status;
    
    @Column(name = "username")
    private String username;
    
    @Column(name = "password")
    private String password;

    // Getters and Setters
}

