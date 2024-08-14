package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "shop")
public class Shop {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int shId;
    
    @Column(name = "shname", nullable = false)
    private String shname;
    
    @Column(name = "reg_no")
    private String regNo;
    
    @Column(name = "license_no")
    private String licenseNo;
    
    @ManyToOne
    @JoinColumn(name = "u_id")
    private User user;
    
    @ManyToOne
    @JoinColumn(name = "a_id")
    private Area area;
    
    @Column(name = "address")
    private String address;

    // Getters and Setters
}

